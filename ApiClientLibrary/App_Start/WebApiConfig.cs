using System.Web.Http;

namespace ApiClientLibrary
{
    public static class WebApiConfig
    {
        private const string DefaultRouteName = "MS_attributerouteWebApi";

        public static void Register(HttpConfiguration config)
        {
            if (!config.Routes.ContainsKey(DefaultRouteName))
            {
                config.MapHttpAttributeRoutes();
            }

            config.Routes.MapHttpRoute("WebApi", "api/{controller}/{id}", new { id = RouteParameter.Optional });
        }
    }
}