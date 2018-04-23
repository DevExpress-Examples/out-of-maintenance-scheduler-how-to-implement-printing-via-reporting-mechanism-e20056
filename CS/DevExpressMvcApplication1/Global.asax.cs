// Developer Express Code Central Example:
// Scheduler - Getting Started - Lesson 1 - Show appointments in read-only mode
// 
// This example demonstrates how to show appointments in a simple scheduling
// application using MVC Scheduling Extensions bound to data. We suggest that you
// review it if you are a first-time user of the ASP .NET MVC Scheduler.
// Note that
// the scheduler is in read-only mode to make the code easier to understand.
// This
// project is created by following the step-by-step guide of the Lesson 1 - Use
// Scheduler to Display Appointments in Read-Only Mode
// (ms-help://DevExpress.NETv12.1/DevExpress.AspNet/CustomDocument11554.htm).
// To
// learn how to implement the appointment editing functionality, review
// step-by-step guide in the Lesson 2 - Implement Insert-Update-Delete Appointment
// Functionality
// (ms-help://DevExpress.NETv12.1/DevExpress.AspNet/CustomDocument11567.htm) and
// see the result in the http://www.devexpress.com/scid=E3984 example.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3971

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace DevExpressMvcApplication1
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }

        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            routes.IgnoreRoute("{resource}.ashx/{*pathInfo}");

            routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = UrlParameter.Optional } // Parameter defaults
            );

        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            RegisterGlobalFilters(GlobalFilters.Filters);
            RegisterRoutes(RouteTable.Routes);
        }
    }
}