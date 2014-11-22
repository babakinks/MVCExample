using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Ninject;
using SportsStore.WebUI.Infrastructure;

namespace SportsStore.WebUI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            this.RegisterDependencyResolver();
        }

        private void RegisterDependencyResolver()
        {
            var kernel = new StandardKernel();

            // you may need to configure your container here?
            //RegisterServices(kernel);

            DependencyResolver.SetResolver(new NinjectDependencyResolver(kernel));
        }
    }
}
