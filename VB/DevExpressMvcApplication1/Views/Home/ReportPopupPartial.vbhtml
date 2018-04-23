@Html.DevExpress().PopupControl( _
    Sub(settings)
            settings.Name = "popupControl"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "ReportPopupPartial"}
            settings.CloseAction = CloseAction.OuterMouseClick
            settings.PopupVerticalAlign = PopupVerticalAlign.WindowCenter
            settings.PopupHorizontalAlign = PopupHorizontalAlign.WindowCenter
            settings.Height = System.Web.UI.WebControls.Unit.Pixel(500)
            settings.Width = System.Web.UI.WebControls.Unit.Pixel(1000)
            settings.ShowPageScrollbarWhenModal = True
            settings.ShowLoadingPanel = False
            settings.Modal = True
            settings.ScrollBars = System.Web.UI.WebControls.ScrollBars.Vertical
            settings.LoadContentViaCallback = LoadContentViaCallback.OnFirstShow
            settings.ClientSideEvents.EndCallback = "OnEndCallback"
            settings.ClientSideEvents.CloseUp = "OnPopupClose"
            settings.PopupElementID = "ShowReport"
            settings.HeaderText = "Report Preview"
            settings.SetContent( _
                Sub()
                        Html.RenderAction("ReportView", "Home")
                End Sub)
    End Sub).GetHtml()