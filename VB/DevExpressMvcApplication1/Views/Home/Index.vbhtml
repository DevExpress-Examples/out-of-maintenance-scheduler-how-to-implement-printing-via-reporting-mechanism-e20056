@ModelType SchedulerDataObject
@Code
    ViewBag.Title = "Home"
End Code

<h2>MVC Scheduler Extension</h2>

@Html.Partial("SchedulerPartial", Model)

<div style="height: 100px">
    @Html.DevExpress().Button( _
    Sub(settings)
            settings.Name = "ShowReport"
            settings.Text = "Show Preview"
            settings.ClientSideEvents.Click = "ShowPopupControl"
    End Sub).GetHtml()
</div>

@Html.Partial("ReportPopupPartial")