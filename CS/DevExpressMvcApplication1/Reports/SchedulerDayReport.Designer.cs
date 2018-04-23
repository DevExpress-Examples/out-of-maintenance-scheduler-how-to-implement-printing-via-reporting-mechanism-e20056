namespace DevExpressMvcApplication1.Reports {
    partial class SchedulerDayReport {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.horizontalResourceHeaders1 = new DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders();
            this.reportDayView1 = new DevExpress.XtraScheduler.Reporting.ReportDayView();
            this.dayViewTimeCells1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeCells();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.timeIntervalInfo1 = new DevExpress.XtraScheduler.Reporting.TimeIntervalInfo();
            this.calendarControl1 = new DevExpress.XtraScheduler.Reporting.CalendarControl();
            this.dayViewTimeRuler1 = new DevExpress.XtraScheduler.Reporting.DayViewTimeRuler();
            this.xrPageBreak1 = new DevExpress.XtraReports.UI.XRPageBreak();
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // horizontalResourceHeaders1
            // 
            this.horizontalResourceHeaders1.LocationFloat = new DevExpress.Utils.PointFloat(100F, 129.1667F);
            this.horizontalResourceHeaders1.Name = "horizontalResourceHeaders1";
            this.horizontalResourceHeaders1.SizeF = new System.Drawing.SizeF(550F, 26F);
            this.horizontalResourceHeaders1.View = this.reportDayView1;
            // 
            // dayViewTimeCells1
            // 
            this.dayViewTimeCells1.HorizontalHeaders = this.horizontalResourceHeaders1;
            this.dayViewTimeCells1.LocationFloat = new DevExpress.Utils.PointFloat(100F, 155.1667F);
            this.dayViewTimeCells1.Name = "dayViewTimeCells1";
            this.dayViewTimeCells1.ShowWorkTimeOnly = true;
            this.dayViewTimeCells1.SizeF = new System.Drawing.SizeF(550F, 25F);
            this.dayViewTimeCells1.VerticalLayoutType = DevExpress.XtraScheduler.Reporting.ControlContentLayoutType.Tile;
            this.dayViewTimeCells1.View = this.reportDayView1;
            this.dayViewTimeCells1.VisibleTimeSnapMode = false;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPageBreak1,
            this.timeIntervalInfo1,
            this.calendarControl1,
            this.dayViewTimeRuler1,
            this.horizontalResourceHeaders1,
            this.dayViewTimeCells1});
            this.Detail.HeightF = 182.1667F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // timeIntervalInfo1
            // 
            this.timeIntervalInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.timeIntervalInfo1.Name = "timeIntervalInfo1";
            this.timeIntervalInfo1.SizeF = new System.Drawing.SizeF(278.125F, 129.1667F);
            this.timeIntervalInfo1.TimeCells = this.dayViewTimeCells1;
            // 
            // calendarControl1
            // 
            this.calendarControl1.LocationFloat = new DevExpress.Utils.PointFloat(278.125F, 0F);
            this.calendarControl1.Name = "calendarControl1";
            this.calendarControl1.SizeF = new System.Drawing.SizeF(371.875F, 129.1667F);
            this.calendarControl1.TimeCells = this.dayViewTimeCells1;
            this.calendarControl1.View = this.reportDayView1;
            // 
            // dayViewTimeRuler1
            // 
            this.dayViewTimeRuler1.LocationFloat = new DevExpress.Utils.PointFloat(3.178914E-05F, 155.1667F);
            this.dayViewTimeRuler1.Name = "dayViewTimeRuler1";
            this.dayViewTimeRuler1.SizeF = new System.Drawing.SizeF(100F, 25F);
            this.dayViewTimeRuler1.TimeCells = this.dayViewTimeCells1;
            this.dayViewTimeRuler1.View = this.reportDayView1;
            // 
            // xrPageBreak1
            // 
            this.xrPageBreak1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 180.1667F);
            this.xrPageBreak1.Name = "xrPageBreak1";
            // 
            // SchedulerDayReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail});
            this.Version = "12.1";
            this.Views.AddRange(new DevExpress.XtraScheduler.Reporting.ReportViewBase[] {
            this.reportDayView1});
            ((System.ComponentModel.ISupportInitialize)(this.reportDayView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraScheduler.Reporting.HorizontalResourceHeaders horizontalResourceHeaders1;
        private DevExpress.XtraScheduler.Reporting.ReportDayView reportDayView1;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeCells dayViewTimeCells1;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraScheduler.Reporting.DayViewTimeRuler dayViewTimeRuler1;
        private DevExpress.XtraScheduler.Reporting.TimeIntervalInfo timeIntervalInfo1;
        private DevExpress.XtraScheduler.Reporting.CalendarControl calendarControl1;
        private DevExpress.XtraReports.UI.XRPageBreak xrPageBreak1;

    }
}
