using System.Web.Http;

namespace OwinWebApi.Controllers
{
    public class PingController : ApiController
    {
        public string Get()
        {
            return "ping";
        }
    }
}