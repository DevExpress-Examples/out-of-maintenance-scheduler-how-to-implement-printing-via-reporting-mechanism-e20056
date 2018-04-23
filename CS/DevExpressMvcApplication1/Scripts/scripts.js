function ShowPopupControl(s, e) {
    popupControl.PerformCallback();
}

function ReportViewerBeginCallback(s, e) {
    var visibleIntervals = scheduler.GetVisibleIntervals();
    var count = visibleIntervals.length;
    e.customArgs["StartDate"] = visibleIntervals[0].start.getTime();
    e.customArgs["EndDate"] = visibleIntervals[count - 1].end.getTime();
}

function OnEndCallback(s, e) {
    popupControl.Show();
}

function OnPopupClose(s, e) {
    popupControl.SetContentHtml("");
}