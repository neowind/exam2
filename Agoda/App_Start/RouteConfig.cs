using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Agoda
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DefaultApi",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Static", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default/Static",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Static", id = UrlParameter.Optional }
            );

            routes.MapRoute(
                name: "Default/Ajax",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Default", action = "Ajax", id = UrlParameter.Optional }
            );
        }
    }
}