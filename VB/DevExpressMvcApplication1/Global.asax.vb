' Developer Express Code Central Example:
' Scheduler - Getting Started - Lesson 1 - Show appointments in read-only mode
' 
' This example demonstrates how to show appointments in a simple scheduling
' application using MVC Scheduling Extensions bound to data. We suggest that you
' review it if you are a first-time user of the ASP .NET MVC Scheduler.
' Note that
' the scheduler is in read-only mode to make the code easier to understand.
' This
' project is created by following the step-by-step guide of the Lesson 1 - Use
' Scheduler to Display Appointments in Read-Only Mode
' (ms-help://DevExpress.NETv12.1/DevExpress.AspNet/CustomDocument11554.htm).
' To
' learn how to implement the appointment editing functionality, review
' step-by-step guide in the Lesson 2 - Implement Insert-Update-Delete Appointment
' Functionality
' (ms-help://DevExpress.NETv12.1/DevExpress.AspNet/CustomDocument11567.htm) and
' see the result in the http://www.devexpress.com/scid=E3984 example.
' 
' You can find sample updates and versions for different programming languages here:
' http://www.devexpress.com/example=E3971


Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.Mvc
Imports System.Web.Routing

Namespace DevExpressMvcApplication1
	' Note: For instructions on enabling IIS6 or IIS7 classic mode, 
	' visit http://go.microsoft.com/?LinkId=9394801

	Public Class MvcApplication
		Inherits System.Web.HttpApplication
		Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)
			filters.Add(New HandleErrorAttribute())
		End Sub

		Public Shared Sub RegisterRoutes(ByVal routes As RouteCollection)
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}")
			routes.IgnoreRoute("{resource}.ashx/{*pathInfo}")

			routes.MapRoute("Default", "{controller}/{action}/{id}", New With {Key .controller = "Home", Key .action = "Index", Key .id = UrlParameter.Optional})

		End Sub

		Protected Sub Application_Start()
			AreaRegistration.RegisterAllAreas()

			RegisterGlobalFilters(GlobalFilters.Filters)
			RegisterRoutes(RouteTable.Routes)
		End Sub
	End Class
End Namespace