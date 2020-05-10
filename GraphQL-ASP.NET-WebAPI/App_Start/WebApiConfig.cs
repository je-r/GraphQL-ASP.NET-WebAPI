using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace GraphQL_ASP.NET_WebAPI
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            var bootstrapper = new Bootstrapper();
            config.DependencyResolver = bootstrapper.Resolver();


            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
