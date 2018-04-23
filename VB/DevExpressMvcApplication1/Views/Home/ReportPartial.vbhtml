 @Html.DevExpress().ReportToolbar( _
    Sub(settings)
        settings.Name = "ReportToolbar"
            settings.Width = System.Web.UI.WebControls.Unit.Percentage(99)
        settings.ReportViewerName = "reportViewer1"
    End Sub).GetHtml()

@Html.Partial("ReportViewerPartial")