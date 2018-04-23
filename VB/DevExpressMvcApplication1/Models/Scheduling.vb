Imports System.Collections
Imports System.Linq
Imports DevExpressMvcApplication1
Imports DevExpress.Web.Mvc
Imports DevExpress.XtraScheduler.Reporting
Imports DevExpress.XtraScheduler
Imports System
Imports DevExpressMvcApplication1.Models

Public Class SchedulerDataObject
    Public Property Appointments() As IEnumerable
    Public Property Resources() As IEnumerable
End Class

Public Class SchedulerDataHelper
    Public Shared Function GetResources() As IEnumerable
        Dim db As New SchedulingDataClassesDataContext()
        Return From res In db.DBResources _
               Select res
    End Function
    Public Shared Function GetAppointments() As IEnumerable
        Dim db As New SchedulingDataClassesDataContext()
        Return From apt In db.DBAppointments _
               Select apt
    End Function
    Public Shared ReadOnly Property DataObject() As SchedulerDataObject
        Get
            Return New SchedulerDataObject() With {.Appointments = GetAppointments(), .Resources = GetResources()}
        End Get
    End Property


    Private Shared defaultAppointmentStorage_Renamed As MVCxAppointmentStorage
    Public Shared ReadOnly Property DefaultAppointmentStorage() As MVCxAppointmentStorage
        Get
            If defaultAppointmentStorage_Renamed Is Nothing Then
                defaultAppointmentStorage_Renamed = CreateDefaultAppointmentStorage()
            End If
            Return defaultAppointmentStorage_Renamed
        End Get
    End Property

    Private Shared Function CreateDefaultAppointmentStorage() As MVCxAppointmentStorage
        Dim appointmentStorage As New MVCxAppointmentStorage()
        appointmentStorage.Mappings.AppointmentId = "UniqueID"
        appointmentStorage.Mappings.Start = "StartDate"
        appointmentStorage.Mappings.End = "EndDate"
        appointmentStorage.Mappings.Subject = "Subject"
        appointmentStorage.Mappings.Description = "Description"
        appointmentStorage.Mappings.Location = "Location"
        appointmentStorage.Mappings.AllDay = "AllDay"
        appointmentStorage.Mappings.Type = "Type"
        appointmentStorage.Mappings.RecurrenceInfo = "RecurrenceInfo"
        appointmentStorage.Mappings.ReminderInfo = "ReminderInfo"
        appointmentStorage.Mappings.Label = "Label"
        appointmentStorage.Mappings.Status = "Status"
        appointmentStorage.Mappings.ResourceId = "ResourceID"
        Return appointmentStorage
    End Function


    Private Shared defaultResourceStorage_Renamed As MVCxResourceStorage
    Public Shared ReadOnly Property DefaultResourceStorage() As MVCxResourceStorage
        Get
            If defaultResourceStorage_Renamed Is Nothing Then
                defaultResourceStorage_Renamed = CreateDefaultResourceStorage()
            End If
            Return defaultResourceStorage_Renamed
        End Get
    End Property
    Private Shared Function CreateDefaultResourceStorage() As MVCxResourceStorage
        Dim resourceStorage As New MVCxResourceStorage()
        resourceStorage.Mappings.ResourceId = "ResourceID"
        resourceStorage.Mappings.Caption = "ResourceName"
        Return resourceStorage
    End Function

    Public Shared Function CreateSchedulerStoragePrintAdapter(ByVal interval As TimeInterval) As SchedulerStoragePrintAdapter
        Dim storage As New SchedulerStorage()
        SetSchedulerReportMappings(storage)

        storage.Appointments.DataSource = SchedulerDataHelper.DataObject.Appointments

        Dim adapter As New SchedulerStoragePrintAdapter(storage)

        adapter.TimeInterval = interval
        adapter.WorkTime = New TimeOfDayInterval(TimeSpan.FromHours(8), TimeSpan.FromHours(20))
        Return adapter
    End Function

    Private Shared Sub SetSchedulerReportMappings(ByVal storage As SchedulerStorage)
        storage.Appointments.Mappings.AppointmentId = "UniqueID"
        storage.Appointments.Mappings.Start = "StartDate"
        storage.Appointments.Mappings.End = "EndDate"
        storage.Appointments.Mappings.Subject = "Subject"
        storage.Appointments.Mappings.Description = "Description"
        storage.Appointments.Mappings.Location = "Location"
        storage.Appointments.Mappings.AllDay = "AllDay"
        storage.Appointments.Mappings.Type = "Type"
        storage.Appointments.Mappings.RecurrenceInfo = "RecurrenceInfo"
        storage.Appointments.Mappings.ReminderInfo = "ReminderInfo"
        storage.Appointments.Mappings.Label = "Label"
        storage.Appointments.Mappings.Status = "Status"
        storage.Appointments.Mappings.ResourceId = "ResourceID"
    End Sub
End Class