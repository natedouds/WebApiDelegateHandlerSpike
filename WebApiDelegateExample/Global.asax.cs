using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using FileLogger;

namespace WebApiDelegateExample
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            TestLogger();
        }

        private void TestLogger()
        {
            var dir = HttpRuntime.BinDirectory + "logging\\";
            var file = WebConfigurationManager.AppSettings["loggerFileName"];
            var logger = new Logger();
            logger.CreateFile(dir, file);
        }
    }
}
