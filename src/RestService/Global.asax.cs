﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web.Routing;
using Autofac;
using Microsoft.ApplicationServer.Http.Activation;
using Microsoft.ApplicationServer.Http.Description;
using TellagoStudios.Hermes.Logging;
using TellagoStudios.Hermes.RestService.Pushing;
using TellagoStudios.Hermes.RestService.Resources;
using TellagoStudios.Hermes.Business.Events;

namespace TellagoStudios.Hermes.RestService
{
    public class Global : System.Web.HttpApplication
    {
        private IEventAggregator _aggregator;
        private void Initialize()
        {

            var cs = ConfigurationManager.ConnectionStrings["db.connectionString"];
            if (cs == null)
            {
                throw new ConfigurationErrorsException(
                    "A connection string names \"db.connectionString\" is missing at configuration file.");
            }

            
            var builder = new ContainerBuilder();
            
            typeof(Global).Assembly
                          .GetTypes()
                          .Where(t => typeof(Module).IsAssignableFrom(t) && !t.IsAbstract)
                          .Select(Activator.CreateInstance).OfType<Module>()
                          .ToList().ForEach(builder.RegisterModule);

            var container = builder.Build();
            
            #region Initialize Routes

            IHttpHostConfigurationBuilder config;
            if (!container.TryResolve(out config))
            {
                config = HttpHostConfiguration.Create()
                    .SetResourceFactory(new AutofacResourceFactory(container));
            }

            RouteTable.Routes.MapServiceRoute<TopicsResource>(Constants.Routes.Topics, config);
            RouteTable.Routes.MapServiceRoute<MessageResource>(Constants.Routes.Messages, config);
            RouteTable.Routes.MapServiceRoute<GroupsResource>(Constants.Routes.Groups, config);
            RouteTable.Routes.MapServiceRoute<SubscriptionResource>(Constants.Routes.Subscriptions, config);
            RouteTable.Routes.MapServiceRoute<LogResource>(Constants.Routes.Log, config);

            #endregion

            #region Initial Process of Retries queue

            var retryService = container.Resolve<IRetryService>();
            retryService.ProcessRetries();

            _aggregator = container.Resolve<IEventAggregator>();
            var handlers = container.Resolve<IEnumerable<IEventHandler>>();
            foreach (var handler in handlers)
            {
                _aggregator.Subscribe(handler);
            }

            #endregion

            System.Diagnostics.Trace.Listeners.Clear();
            System.Diagnostics.Trace.Listeners.Add(new MongoTraceListener(container.Resolve<ILogService>()));
        }

        void Application_Start(object sender, EventArgs e)
        {
            log4net.Config.XmlConfigurator.Configure();
            Initialize();
        }        
    }
}
