using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace UNPApi
{
    ///<Summary>
    /// WebApi
    ///</Summary>
    public static class WebApiConfig
    {
        ///<Summary>
        /// Register Method
        ///</Summary>
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Enable cors
            var cors = new EnableCorsAttribute("*", "*", "*");
            config.EnableCors(cors);
            // Web API routes
            config.MapHttpAttributeRoutes();
            config.MessageHandlers.Add(new TokenValidationHandler());
            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
