using Owin;
using System.Web.Http;

namespace OwinWebApi
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();

            config.Routes.MapHttpRoute(
                name: "api",
                routeTemplate: "api/{controller}",
                defaults: new { controller = "Ping", action = "Get" }
            );

            appBuilder.UseWebApi(config);
        }
    }
}