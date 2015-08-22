using System.Web.Mvc;
using System.Web.Routing;

namespace HyperWeb
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "HyperSoaConfigSchemaRoute",
                url: "HyperSoaConfigSchema",
                defaults: new { controller = "Home", action = "HyperSoaConfigSchema", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
