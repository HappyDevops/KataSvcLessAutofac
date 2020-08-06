using System;
using System.ServiceModel.Activation;
using System.Web;
using System.Web.Routing;
using Autofac;
using Autofac.Integration.Wcf;
using Kata.WcfSvcLessAutofac.Code;

namespace Kata.WcfSvcLessAutofac
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            var container = ComposeContainer();
            AutofacHostFactory.Container = container;

            ConfigureServiceRoutes();
        }

        private void ConfigureServiceRoutes()
        {
            const string routePrefix = "SvcLessService";
            var factory = new AutofacServiceHostFactory();
            var serviceType = typeof(ExampleService);

            RouteBase route = new ServiceRoute(routePrefix,factory, serviceType);
            RouteTable.Routes.Add(route);
        }

        private IContainer ComposeContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.Register(c => new ExampleService())
                .AsSelf()
                .InstancePerDependency();

            return containerBuilder.Build();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}