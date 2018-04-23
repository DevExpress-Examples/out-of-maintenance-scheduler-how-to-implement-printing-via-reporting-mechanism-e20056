using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.XtraReports.UI;
using DevExpress.XtraScheduler;
using DevExpressMvcApplication1.Reports;

namespace DevExpressMvcApplication1.Views {
    public class HomeController : Controller {

        #region Scheduler
        public ActionResult Index() {
            return View(SchedulerDataHelper.DataObject);
        }

        public ActionResult SchedulerPartial() {
            return PartialView("SchedulerPartial", SchedulerDataHelper.DataObject);
        }
        #endregion


        #region Report
        public ActionResult ReportView() {
            return View("ReportView");
        }

        public ActionResult ReportViewerPartial(TimeInterval interval) {
            ViewData["Report"] = CreateReport();
            return PartialView("ReportViewerPartial");
        }

        public ActionResult ExportReportViewerPartial() {
            return DevExpress.Web.Mvc.ReportViewerExtension.ExportTo(CreateReport());
        }

        DateTime Start { get { return ParseDate(Request.Params["StartDate"]); } }
        DateTime End { get { return ParseDate(Request.Params["EndDate"]); } }

        DateTime ParseDate(string utcDateString) {
            DateTime utcDate = new DateTime(1970, 01, 01).AddMilliseconds(Convert.ToDouble(utcDateString));
            return SchedulerTimeZone.CurrentTimeZone.ToLocalTime(utcDate);
        }

        XtraReport CreateReport() {
            SchedulerDayReport report = new SchedulerDayReport();
            report.SchedulerAdapter = SchedulerDataHelper.CreateSchedulerStoragePrintAdapter(new TimeInterval(Start, End));
            return report as XtraReport;
        }
        #endregion


        #region Popup
        public ActionResult ReportPopupPartial() {
            return PartialView("ReportPopupPartial");
        }
        #endregion
    }
}
