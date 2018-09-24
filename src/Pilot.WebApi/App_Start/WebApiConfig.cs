using System;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Pilot.WebApi
{
    public static class WebApiConfig
    {
        public static readonly int[] ApiVersions = {1};

        public static void Register(HttpConfiguration config, bool mapAttributeRoutes)
        {
            if (mapAttributeRoutes)
            {
                config.MapHttpAttributeRoutes();
            }

            config.Routes.MapHttpRoute(
                name: "VersionedApi",
                routeTemplate: "api/v{version}/{controller}/{id}",
                defaults: new {id = RouteParameter.Optional},
                constraints: new {version = String.Join("|", ApiVersions)}
                );

            // Versionless api support for systeminfo
            config.Routes.MapHttpRoute(
                name: "SystemInfo",
                routeTemplate: "api/systeminfo",
                defaults: new { controller = "SystemInfo"}
                );

            config.Routes.MapHttpRoute(
                name: "Index",
                routeTemplate: "{id}.html",
                defaults: new {id = "index"});

            config.EnableCors(new EnableCorsAttribute("*", "*", "*", "Location"));
        }
    }
}
