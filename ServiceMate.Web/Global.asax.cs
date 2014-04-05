using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace ServiceMate.Web
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
            log4net.Config.XmlConfigurator.Configure();
        }

        protected void Application_Error()
        {
            Exception unhandledException = Server.GetLastError();
            int httpCode = 0;

            // Handle HTTP errors
            if (unhandledException.GetType() == typeof(HttpException))
            {
                HttpException httpException = unhandledException as HttpException;

                if (httpException == null)
                {
                    Exception innerException = unhandledException.InnerException;
                    httpException = innerException as HttpException;
                }

                if (httpException != null)
                {
                    httpCode = httpException.GetHttpCode();
                    switch (httpCode)
                    {
                        case (int)HttpStatusCode.Unauthorized:
                            Response.Redirect("/Http/Error401");
                            break;
                        case 400:
                            Response.Redirect("~/HTTP404Error.aspx");
                            break;
                        default: Response.Redirect("~/");
                            break;
                    }
                }
            }
            log4net.ILog log = log4net.LogManager.GetLogger(this.GetType());
            log.Error(unhandledException.ToString()); 
         
            Server.ClearError();
        }
    }

}