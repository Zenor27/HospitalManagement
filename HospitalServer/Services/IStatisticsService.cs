using HospitalEntities.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace HospitalServer.Services
{
    [ServiceContract]
    public interface IStatisticsService
    {
        [OperationContract]
        int GetTotalAppointments(UserTypeEnum userType, int userId);

        [OperationContract]
        int GetNewAppointmentsIn24Hours(UserTypeEnum userType, int userId);

        [OperationContract]
        int GetComingNextAppointmentsNumber(UserTypeEnum userType, int userId);

        [OperationContract]
        Appointment GetComingNextAppointment(UserTypeEnum userType, int userId);

        [OperationContract]
        int GetAvailableDoctorsNumber();

        [OperationContract]
        int GetLast24HoursAvailableDoctors();

        [OperationContract]
        int GetApprovalWaitingAppointmentsNumber(UserTypeEnum userType, int userId);

        [OperationContract]
        int GetLast24HoursWaitingAppointments(UserTypeEnum userType, int userId);

        [OperationContract]
        int GetTotalHospitalPatients();

        [OperationContract]
        int GetLast24HoursNewPatients();

        [OperationContract]
        int GetTodayAppointmentsNumber(UserTypeEnum userType, int userId);

        [OperationContract]
        int GetNumberOfAppointmentsCompareToYesterday(UserTypeEnum userType, int userId);

        [OperationContract]
        Dictionary<string, int> GetMonthAppointmentsNumber(UserTypeEnum userType, int userId);

        [OperationContract]
        Dictionary<string, int> GetHospitalMonthAppointmentsNumber();
    }
}
