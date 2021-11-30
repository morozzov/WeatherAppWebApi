using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace ServerWebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Конфигурация и службы веб-API

            // Маршруты веб-API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}"
            );

            config.Formatters.Remove(GlobalConfiguration.Configuration.Formatters.XmlFormatter);
            config.Formatters.Add(GlobalConfiguration.Configuration.Formatters.JsonFormatter);
        }
    }
}
