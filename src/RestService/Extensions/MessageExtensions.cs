﻿using Model = TellagoStudios.Hermes.Business.Model;

namespace TellagoStudios.Hermes.RestService.Extensions
{
    public static class MessageExtensions
    {
        static public Facade.Link ToLink(this Model.Message from)
        {
            if (from == null) return null;

            return new Facade.Link
            {
                rel = Business.Constants.Relationships.Message,
                href = Business.ResourceLocation.OfMessageByTopic(from)
            };
        }

        static public Facade.Link ToLink(this Model.MessageKey from)
        {
            if (from == null) return null;

            return new Facade.Link
            {
                rel = Business.Constants.Relationships.Message,
                href = Business.ResourceLocation.OfMessageByTopic(from)
            };
        }
    }
}