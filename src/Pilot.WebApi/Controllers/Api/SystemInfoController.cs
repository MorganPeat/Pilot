using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Pilot.WebApi.Controllers.Api
{
    public class SystemInfoController : ApiController
    {
        [AllowAnonymous]
        public HttpResponseMessage GetSystemInfo()
        {
            return Request.CreateResponse(HttpStatusCode.OK, new { Result="ok"});
        }
    }
}
