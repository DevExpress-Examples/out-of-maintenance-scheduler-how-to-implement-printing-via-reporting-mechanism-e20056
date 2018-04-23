using System.Collections;
using System.Linq;
using DevExpressMvcApplication1;
using DevExpress.Web.Mvc;
using DevExpress.XtraScheduler.Reporting;
using DevExpress.XtraScheduler;
using System;
using DevExpressMvcApplication1.Models;

public class SchedulerDataObject {
    public IEnumerable Appointments { get; set; }
    public IEnumerable Resources { get; set; }
}

public class SchedulerDataHelper {
    public static IEnumerable GetResources() {
        SchedulingDataClassesDataContext db = new SchedulingDataClassesDataContext();
        return from res in db.DBResources select res;
    }
    public static IEnumerable GetAppointments() {
        SchedulingDataClassesDataContext db = new SchedulingDataClassesDataContext();
        return from apt in db.DBAppointments select apt;
    }
    public static SchedulerDataObject DataObject {
        get {
            return new SchedulerDataObject() {
                Appointments = GetAppointments(),
                Resources = GetResources()
            };
        }
    }

    static MVCxAppointmentStorage defaultAppointmentStorage;
    public static MVCxAppointmentStorage DefaultAppointmentStorage {
        get {
            if (defaultAppointmentStorage == null)
                defaultAppointmentStorage = CreateDefaultAppointmentStorage();
            return defaultAppointmentStorage;
        }
    }

    static MVCxAppointmentStorage CreateDefaultAppointmentStorage() {
        MVCxAppointmentStorage appointmentStorage = new MVCxAppointmentStorage();
        appointmentStorage.Mappings.AppointmentId = "UniqueID";
        appointmentStorage.Mappings.Start = "StartDate";
        appointmentStorage.Mappings.End = "EndDate";
        appointmentStorage.Mappings.Subject = "Subject";
        appointmentStorage.Mappings.Description = "Description";
        appointmentStorage.Mappings.Location = "Location";
        appointmentStorage.Mappings.AllDay = "AllDay";
        appointmentStorage.Mappings.Type = "Type";
        appointmentStorage.Mappings.RecurrenceInfo = "RecurrenceInfo";
        appointmentStorage.Mappings.ReminderInfo = "ReminderInfo";
        appointmentStorage.Mappings.Label = "Label";
        appointmentStorage.Mappings.Status = "Status";
        appointmentStorage.Mappings.ResourceId = "ResourceID";
        return appointmentStorage;
    }

    static MVCxResourceStorage defaultResourceStorage;
    public static MVCxResourceStorage DefaultResourceStorage {
        get {
            if (defaultResourceStorage == null)
                defaultResourceStorage = CreateDefaultResourceStorage();
            return defaultResourceStorage;
        }
    }
    static MVCxResourceStorage CreateDefaultResourceStorage() {
        MVCxResourceStorage resourceStorage = new MVCxResourceStorage();
        resourceStorage.Mappings.ResourceId = "ResourceID";
        resourceStorage.Mappings.Caption = "ResourceName";
        return resourceStorage;
    }

    public static SchedulerStoragePrintAdapter CreateSchedulerStoragePrintAdapter(TimeInterval interval) {
        SchedulerStorage storage = new SchedulerStorage();
        SetSchedulerReportMappings(storage);

        storage.Appointments.DataSource = SchedulerDataHelper.DataObject.Appointments;

        SchedulerStoragePrintAdapter adapter = new SchedulerStoragePrintAdapter(storage);

        adapter.TimeInterval = interval;
        adapter.WorkTime = new TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(20));
        return adapter;
    }

    static void SetSchedulerReportMappings(SchedulerStorage storage) {
        storage.Appointments.Mappings.AppointmentId = "UniqueID";
        storage.Appointments.Mappings.Start = "StartDate";
        storage.Appointments.Mappings.End = "EndDate";
        storage.Appointments.Mappings.Subject = "Subject";
        storage.Appointments.Mappings.Description = "Description";
        storage.Appointments.Mappings.Location = "Location";
        storage.Appointments.Mappings.AllDay = "AllDay";
        storage.Appointments.Mappings.Type = "Type";
        storage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo";
        storage.Appointments.Mappings.ReminderInfo = "ReminderInfo";
        storage.Appointments.Mappings.Label = "Label";
        storage.Appointments.Mappings.Status = "Status";
        storage.Appointments.Mappings.ResourceId = "ResourceID";
    }
}