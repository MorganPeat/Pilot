using System.Web.Mvc;
using System.Web.Routing;

namespace Pilot.WebApi
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("favicon.ico");

            routes.MapRoute("Home", "", new { controller = "Home", action = "Index" });
        }
    }
}