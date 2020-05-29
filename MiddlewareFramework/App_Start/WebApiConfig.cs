using MiddlewareFramework.Handlers;
using System.Web.Http;

namespace MiddlewareFramework
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Include handler for middleware
            config.MessageHandlers.Add(new MessageHandler()); // global message handler

            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
