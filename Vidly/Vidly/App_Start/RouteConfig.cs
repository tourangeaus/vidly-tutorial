﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    name: "MoviesByReleaseDate",
            //    url: "movie/released/{year}/{month}",
            //    defaults: new { controller = "Movie", action= "ByReleaseDate"},
            //    constraints: new { year = @"\d{4}", month = @"\d{2}" }
            //    // Specific Range Constraint
            //    // constraints: new { year = @"2015|2016", month = @"\d{2}" }
            //);

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
