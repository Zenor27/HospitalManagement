using HospitalEntities.Models;
using System.Collections.Generic;
using System.ComponentModel;
using System.ServiceModel;
using HospitalServer.Dto;
using HospitalServer.Requests;

namespace HospitalServer.Services
{
    [ServiceContract]
    public interface IAppointmentsService
    {
        [OperationContract]
        IEnumerable<Appointment> GetTodaysAppointments(UserTypeEnum userType, int staffId);

        [OperationContract]
        IEnumerable<Appointment> GetAllAppointmentsIncludingPatientAndStaff(UserTypeEnum userType, int id);

        [OperationContract]
        Appointment GetAppointmentById(int appointmentId);

        [OperationContract]
        ResponseErrorEnum? AddAppointment(AddAppointmentRequest request);

        [OperationContract]
        bool UpdatePatientBackgroundAndAppointmentDescription(int appointmentId, string patientBackground, string appointmentDescription);

        [OperationContract]
        IEnumerable<Appointment> GetWaitingAppointments(UserTypeEnum userType, int id);

        [OperationContract]
        IEnumerable<Appointment> GetAcceptedAppointments(UserTypeEnum userType, int id);

        [OperationContract]
        IEnumerable<Appointment> GetRefusedAppointments(UserTypeEnum userType, int id);

        [OperationContract]
        void AcceptAppointment(int appointmentId);

        [OperationContract]
        void RefuseAppointment(int appointmentId);
    }
}
