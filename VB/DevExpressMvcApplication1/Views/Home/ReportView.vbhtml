@ModelType SchedulerDataObject
    
@Code
    ViewBag.Title = "Home"
End Code

<h2>Scheduler Report</h2>

@Html.Partial("ReportPartial", Model)