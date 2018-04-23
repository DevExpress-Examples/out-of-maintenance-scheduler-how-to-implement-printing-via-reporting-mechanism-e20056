    @Html.DevExpress().Scheduler( _
    Sub(settings)
    
            settings.Name = "scheduler"
            settings.CallbackRouteValues = New With {Key .Controller = "Home", Key .Action = "SchedulerPartial"}

            settings.Storage.Appointments.Assign(SchedulerDataHelper.DefaultAppointmentStorage)
            settings.Storage.Resources.Assign(SchedulerDataHelper.DefaultResourceStorage)

            settings.Storage.EnableReminders = False
        
            settings.OptionsCustomization.AllowAppointmentCreate = DevExpress.XtraScheduler.UsedAppointmentType.None
            settings.OptionsCustomization.AllowAppointmentEdit = DevExpress.XtraScheduler.UsedAppointmentType.None
            settings.OptionsCustomization.AllowAppointmentDelete = DevExpress.XtraScheduler.UsedAppointmentType.None

            settings.Width = 800
            settings.Views.DayView.Styles.ScrollAreaHeight = 400

            settings.Start = New DateTime(2012, 4, 18)

    End Sub).Bind(Model.Appointments, Model.Resources).GetHtml()
