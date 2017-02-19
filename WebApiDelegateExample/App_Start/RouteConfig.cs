using System.Web.Mvc;
using System.Web.Routing;

namespace WebApiDelegateExample
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                "Default",
                "api/{controller}/{id}"
            );
        }
    }
}
