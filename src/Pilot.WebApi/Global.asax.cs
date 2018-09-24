using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Routing;

namespace Pilot.WebApi
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {                       
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(config => WebApiConfig.Register(config, true));
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);            
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }        
    }
}