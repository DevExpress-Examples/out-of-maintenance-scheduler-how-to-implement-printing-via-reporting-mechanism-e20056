Imports Microsoft.VisualBasic
Imports System
Namespace DevExpressMvcApplication1.Reports
	Partial Public Class SchedulerDayReport
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.horizontalResourceHeaders1 = New DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders()
            Me.dayViewTimeCells1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeCells()
            Me.calendarControl1 = New DevExpress.XtraScheduler.Reporting.CalendarControl()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrPageBreak1 = New DevExpress.XtraReports.UI.XRPageBreak()
            Me.dayViewTimeRuler1 = New DevExpress.XtraScheduler.Reporting.DayViewTimeRuler()
            Me.timeIntervalInfo1 = New DevExpress.XtraScheduler.Reporting.TimeIntervalInfo()
            Me.reportDayView1 = New DevExpress.XtraScheduler.Reporting.ReportDayView()
            CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            '
            'horizontalResourceHeaders1
            '
            Me.horizontalResourceHeaders1.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 129.1667!)
            Me.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1"
            Me.horizontalResourceHeaders1.SizeF = New System.Drawing.SizeF(550.0!, 26.0!)
            Me.horizontalResourceHeaders1.View = Me.reportDayView1
            '
            'dayViewTimeCells1
            '
            Me.dayViewTimeCells1.HorizontalHeaders = Me.horizontalResourceHeaders1
            Me.dayViewTimeCells1.LocationFloat = New DevExpress.Utils.PointFloat(100.0!, 155.1667!)
            Me.dayViewTimeCells1.Name = "dayViewTimeCells1"
            Me.dayViewTimeCells1.ShowWorkTimeOnly = True
            Me.dayViewTimeCells1.SizeF = New System.Drawing.SizeF(550.0!, 25.0!)
            Me.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile
            Me.dayViewTimeCells1.View = Me.reportDayView1
            Me.dayViewTimeCells1.VisibleTimeSnapMode = False
            '
            'calendarControl1
            '
            Me.calendarControl1.LocationFloat = New DevExpress.Utils.PointFloat(278.125!, 0.0!)
            Me.calendarControl1.Name = "calendarControl1"
            Me.calendarControl1.SizeF = New System.Drawing.SizeF(371.875!, 129.1667!)
            Me.calendarControl1.TimeCells = Me.dayViewTimeCells1
            Me.calendarControl1.View = Me.reportDayView1
            '
            'Detail
            '
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPageBreak1, Me.timeIntervalInfo1, Me.calendarControl1, Me.dayViewTimeRuler1, Me.horizontalResourceHeaders1, Me.dayViewTimeCells1})
            Me.Detail.HeightF = 182.1667!
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100.0!)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            '
            'xrPageBreak1
            '
            Me.xrPageBreak1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 180.1667!)
            Me.xrPageBreak1.Name = "xrPageBreak1"
            '
            'dayViewTimeRuler1
            '
            Me.dayViewTimeRuler1.LocationFloat = New DevExpress.Utils.PointFloat(0.00003178914!, 155.1667!)
            Me.dayViewTimeRuler1.Name = "dayViewTimeRuler1"
            Me.dayViewTimeRuler1.SizeF = New System.Drawing.SizeF(100.0!, 25.0!)
            Me.dayViewTimeRuler1.TimeCells = Me.dayViewTimeCells1
            Me.dayViewTimeRuler1.View = Me.reportDayView1
            '
            'timeIntervalInfo1
            '
            Me.timeIntervalInfo1.LocationFloat = New DevExpress.Utils.PointFloat(0.0!, 0.0!)
            Me.timeIntervalInfo1.Name = "timeIntervalInfo1"
            Me.timeIntervalInfo1.SizeF = New System.Drawing.SizeF(278.125!, 129.1667!)
            Me.timeIntervalInfo1.TimeCells = Me.dayViewTimeCells1
            '
            'SchedulerDayReport
            '
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail})
            Me.Version = "12.1"
            Me.Views.AddRange(New DevExpress.XtraScheduler.Reporting.ReportViewBase() {Me.reportDayView1})
            CType(Me.reportDayView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub
        Friend WithEvents horizontalResourceHeaders1 As DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders
        Friend WithEvents reportDayView1 As DevExpress.XtraScheduler.Reporting.ReportDayView
        Friend WithEvents dayViewTimeCells1 As DevExpress.XtraScheduler.Reporting.DayViewTimeCells
        Friend WithEvents calendarControl1 As DevExpress.XtraScheduler.Reporting.CalendarControl
        Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
        Friend WithEvents xrPageBreak1 As DevExpress.XtraReports.UI.XRPageBreak
        Friend WithEvents timeIntervalInfo1 As DevExpress.XtraScheduler.Reporting.TimeIntervalInfo
        Friend WithEvents dayViewTimeRuler1 As DevExpress.XtraScheduler.Reporting.DayViewTimeRuler

		#End Region


	End Class
End Namespace
