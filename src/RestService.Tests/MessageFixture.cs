﻿using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Autofac;
using Moq;
using NUnit.Framework;
using System.Net;
using TellagoStudios.Hermes.Business.Data.Queries;
using TellagoStudios.Hermes.Business.Exceptions;
using TellagoStudios.Hermes.Business.Messages;
using TellagoStudios.Hermes.Business.Model;
using TellagoStudios.Hermes.RestService;
using TellagoStudios.Hermes.RestService.Resources;

namespace RestService.Tests
{
    [TestFixture]
    public class MessageFixture : ResourceBaseFixture
    {
        private Mock<IMessageByMessageKey> messageByMessageKey;

        protected override void PopulateApplicationContext(ContainerBuilder builder)
        {
            messageByMessageKey = new Mock<IMessageByMessageKey>();

            builder.RegisterInstance(new MessageResource(messageByMessageKey.Object));
        }

        protected override RestClient.SerializationType GetSerializationType()
        {
            return RestClient.SerializationType.Xml;
        }

        protected override Type GetServiceType()
        {
            return typeof(MessageResource);
        }

        [Test]
        public void Should_get_a_messagge()
        {
            var contentType = "text/text";
            var payload = "Hello!";
            var message = new Message()
            {
                Id = Identity.Random(),
                TopicId = Identity.Random(),
                Payload = Encoding.ASCII.GetBytes(payload),
                UtcReceivedOn = DateTime.UtcNow
            };

            message.Headers.Add("Content-Type", new[] { contentType });

            var key = new MessageKey { MessageId = message.Id.Value, TopicId = message.TopicId };

            messageByMessageKey
                .Setup(r => r.Get(It.Is<MessageKey>(k => k.TopicId == key.TopicId && k.MessageId == key.MessageId)))
                .Returns(message);

            var client = new HttpClient(baseUri);
            var url = baseUri + message.Id.Value.ToString() + "/topic/" + message.TopicId;
            var result = client.Get(url);

            messageByMessageKey.Verify(r => r.Get(It.Is<MessageKey>(k => k.TopicId == key.TopicId && k.MessageId == key.MessageId)));

            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.OK, result.StatusCode);
            Assert.AreEqual(payload, result.Content.ReadAsString());
            Assert.AreEqual(contentType, result.Content.Headers.ContentType.MediaType);
        }

        [Test]
        public void Validates_a_get_with_invalid_data()
        {
            messageByMessageKey.Setup(s => s.Get(It.IsAny<MessageKey>())).Throws<ValidationException>();

            var client = new HttpClient(baseUri);
            var url = baseUri.ToString() + Identity.Random() + "/topic/" + Identity.Random();
            var result = client.Get(url);

            messageByMessageKey.Verify(r => r.Get(It.IsAny<MessageKey>()));

            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.BadRequest, result.StatusCode);
        }

        [Test]
        public void Validates_a_get_of_a_message_that_does_not_exist()
        {
            messageByMessageKey.Setup(s => s.Get(It.IsAny<MessageKey>())).Returns((Message)null);

            var client = new HttpClient(baseUri);
            var url = baseUri.ToString() + Identity.Random() + "/topic/" + Identity.Random();
            var result = client.Get(url);

            messageByMessageKey.Verify(r => r.Get(It.IsAny<MessageKey>()));

            Assert.IsNotNull(result);
            Assert.AreEqual(HttpStatusCode.NotFound, result.StatusCode);
        }
    }
}
