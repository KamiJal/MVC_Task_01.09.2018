using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Routing.Constraints;
using System.Web.Routing;

namespace MVC_Task_01._09._2018
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "GetStopsByDay",
                url: "Stops/{year}/{month}/{day}",
                defaults: new { controller = "Stops", action = "GetStopsByDay" },
                constraints: new
                {
                    year = @"\d{4}",
                    month = new CompoundRouteConstraint(
                        new List<IRouteConstraint>
                        {
                            new LengthRouteConstraint(2),
                            new RangeRouteConstraint(1, 12)
                        }),
                    day = new CompoundRouteConstraint(
                        new List<IRouteConstraint>
                        {
                            new LengthRouteConstraint(2),
                            new RangeRouteConstraint(1, 31)
                        })
                }
            );

            routes.MapRoute(
                name: "GetStopsByMonth",
                url: "Stops/{year}/{month}",
                defaults: new { controller = "Stops", action = "GetStopsByMonth" },
                constraints: new
                {
                    year = @"\d{4}",
                    month = new CompoundRouteConstraint(
                        new List<IRouteConstraint>
                        {
                            new LengthRouteConstraint(2),
                            new RangeRouteConstraint(1, 12)
                        })
                }
            );

            routes.MapRoute(
                name: "GetStopsByYear",
                url: "Stops/{year}",
                defaults: new { controller = "Stops", action = "GetStopsByYear" },
                constraints: new { year = @"\d{4}" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
