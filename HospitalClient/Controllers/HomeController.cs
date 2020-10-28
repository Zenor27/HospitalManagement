using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using HospitalClient.Models;
using StatisticsService;
using MessageService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace HospitalClient.Controllers
{
    [Authorize]
    public class HomeController : ControllerBase
    {
        private readonly IStatisticsService _statisticsClient;
        private readonly IMessageService _messageClient;

        public HomeController(IStatisticsService statisticsClient, IMessageService messageClient)
        {
            _statisticsClient = statisticsClient;
            _messageClient = messageClient;
        }

        // FIXME: Use ViewModel instead of view data
        private void GetAllMyAppointments()
        {
            ViewData["allMyAppointments"] = _statisticsClient.GetTotalAppointments(CurrentUserType, CurrentUserId);
            ViewData["newAppointmentsIn24Hours"] = _statisticsClient.GetNewAppointmentsIn24Hours(CurrentUserType, CurrentUserId);
        }

        private void GetNextAppointmentToday()
        {
            ViewData["nextAppointments"] = _statisticsClient.GetComingNextAppointmentsNumber(CurrentUserType, CurrentUserId);
            var nextAppointment = _statisticsClient.GetComingNextAppointment(CurrentUserType, CurrentUserId);
            if (CurrentUserType == HospitalEntities.Models.UserTypeEnum.PATIENT)
            {
                ViewData["nextAppointment"] = nextAppointment != null ? $"Dr. {nextAppointment.Staff.FirstName} {nextAppointment.Staff.LastName}" : "N/A";
            }
            else
            {

                ViewData["nextAppointment"] = nextAppointment != null ? $"{nextAppointment.Patient.FirstName} {nextAppointment.Patient.LastName}" : "N/A";
            }
        }

        private void GetAvailableStaffs()
        {
            ViewData["availableStaffs"] = _statisticsClient.GetAvailableDoctorsNumber();
            ViewData["24HoursAvailableStaffs"] = _statisticsClient.GetLast24HoursAvailableDoctors();
        }

        private void GetWaitingRequests()
        {
            ViewData["waitingRequests"] = _statisticsClient.GetApprovalWaitingAppointmentsNumber(CurrentUserType, CurrentUserId);
            ViewData["24HoursWaitingRequests"] = _statisticsClient.GetLast24HoursWaitingAppointments(CurrentUserType, CurrentUserId);
        }

        private void GetPatientsTakenInHospital()
        {
            ViewData["patientsTakenInHospital"] = _statisticsClient.GetTotalHospitalPatients();
            ViewData["24HoursNewPatients"] = _statisticsClient.GetLast24HoursNewPatients();
        }

        private void GetTodaysAppointments()
        {
            ViewData["todaysAppointments"] = _statisticsClient.GetTodayAppointmentsNumber(CurrentUserType, CurrentUserId);
            ViewData["appointmentsCompareToYesterday"] = _statisticsClient.GetNumberOfAppointmentsCompareToYesterday(CurrentUserType, CurrentUserId);
        }

        private void GetMessages()
        {
            ViewData["messages"] = _messageClient.GetLastMessages();
        }

        private void GetCharts()
        {
            var monthAppointmentsNumber = _statisticsClient.GetMonthAppointmentsNumber(CurrentUserType, CurrentUserId);
            ViewData["myAppointmentsChart"] = monthAppointmentsNumber;

            var hospitalMonthAppointmentsNumber = _statisticsClient.GetHospitalMonthAppointmentsNumber();
            ViewData["hospitalAppointmentsChart"] = hospitalMonthAppointmentsNumber;
        }

        public IActionResult Index()
        {
            // Get all Datas
            GetAllMyAppointments();
            GetNextAppointmentToday();
            GetAvailableStaffs();
            GetWaitingRequests();
            GetPatientsTakenInHospital();
            GetTodaysAppointments();
            GetCharts();
            GetMessages();

            ViewData["isStaff"] = IsCurrentUserStaff;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
