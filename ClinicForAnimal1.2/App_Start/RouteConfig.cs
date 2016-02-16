using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ClinicForAnimal1._2
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                 defaults: new { controller = "Account", action = "Login", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                null,
                "Page{page}",
                new { controller = "VeterinarianServices", action = "Categories", category = (string)null },
                new { page = @"\d+" });

            routes.MapRoute
                (null,
                "{category}/Page{page}",
                new { controller = "VeterinarianServices", action = "Categories" },
                new { page = @"\d+" });
        }
    }
}
