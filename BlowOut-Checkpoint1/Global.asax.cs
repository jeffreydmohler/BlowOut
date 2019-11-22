using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using BlowOut_Checkpoint1.Models;
using BlowOut_Checkpoint1.DAL;

namespace BlowOut_Checkpoint1
{
    public class MvcApplication : System.Web.HttpApplication
    {

        //like main
        protected void Application_Start()
        {
            Database.SetInitializer<BlowOutContext>(null); 

            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }
    }
}
