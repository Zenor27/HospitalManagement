using System;
using AppointmentsService;
using HospitalClient.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
using HospitalClient.Extensions;
using HospitalEntities.Models;
using HospitalServer.Dto;
using HospitalServer.Requests;
using PatientService;
using StaffService;

namespace HospitalClient.Controllers
{
    [Authorize]
    public class AppointmentsController : ControllerBase
    {
        private readonly IAppointmentsService _appointmentsService;
        private readonly IPatientService _patientService;
        private readonly IStaffService _staffService;

        public AppointmentsController(IAppointmentsService appointmentsService, IPatientService patientService, IStaffService staffService)
        {
            _appointmentsService = appointmentsService;
            _patientService = patientService;
            _staffService = staffService;
        }

        public IActionResult Index()
        {
            // TODO: Retrieve patients and doctors
            var model = new AppointmentsViewModel();
            FillAppointmentViewModel(model);
            model.AddAppointmentViewModel = new AddAppointmentViewModel();
            FillAddAppointmentViewModel(model.AddAppointmentViewModel);

            return View(model);
        }

        private void FillAppointmentViewModel(AppointmentsViewModel model)
        {
            model.TodaysAppointments = _appointmentsService.GetTodaysAppointments(CurrentUserType, CurrentUserId);
            model.AllAppointments = _appointmentsService.GetAllAppointmentsIncludingPatientAndStaff(CurrentUserType, CurrentUserId).Where(a => a.Status == Status.ACCEPTED).ToList();
            model.ShowAddAppointmentButton = IsCurrentUserStaff;
            model.IsStaff = IsCurrentUserStaff;
        }

        private void FillAddAppointmentViewModel(AddAppointmentViewModel model)
        {
            var patients = _patientService.GetPatients();
            var doctors = _staffService.GetStaffs();

            model.Patients = patients.OrderBy(p => p.FullName).ToList();
            model.Doctors = doctors.OrderBy(d => d.FullName).ToList();
        }

        [HttpPost]
        [Authorize(UserRole.STAFF)]
        public IActionResult AddAppointment(AddAppointmentViewModel model)
        {
            if (ModelState.IsValid)
            {
                var succeeded = _patientService.UpdateBackground(model.PatientId, model.PatientBackground);

                if (!succeeded)
                {
                    return this.InternalServerError();
                }

                Debug.Assert(model.Date != null, "model.Date != null");
                Debug.Assert(model.Time != null, "model.Time != null");
                var appointmentDateTime = model.Date.Value.Date + model.Time.Value.TimeOfDay;

                var error = _appointmentsService.AddAppointment(new AddAppointmentRequest
                {
                    CreatedAt = DateTime.Now,
                    Date = appointmentDateTime,
                    Description = model.Description,
                    PatientId = model.PatientId,
                    StaffId = model.DoctorId,
                    CreatorUserType = UserTypeEnum.STAFF
                });

                switch (error)
                {
                    case null:
                        return RedirectToAction("Index");

                    case ResponseErrorEnum.StaffAlreadyHasAppointmentOnDateTime:
                        ModelState.AddModelError(nameof(model.Time), "The doctor already has an appointment at this time.");
                        break;

                    default:
                        return this.InternalServerError();
                }
            }

            var indexModel = new AppointmentsViewModel();
            FillAppointmentViewModel(indexModel);
            indexModel.AddAppointmentViewModel = model;
            FillAddAppointmentViewModel(model);
            indexModel.OpenAddAppointmentModal = true;
            return View("Index", indexModel);
        }

        [HttpPost]
        [Authorize(UserRole.STAFF)]
        public IActionResult UpdatePatientBackgroundAndAppointmentDescription(AppointmentDetailsModel model)
        {
            var succeeded = _appointmentsService.UpdatePatientBackgroundAndAppointmentDescription(model.Appointment.Id,
                                                                                                  model.Appointment.Patient.Background,
                                                                                                  model.Appointment.Description);
            if (!succeeded)
            {
                return this.InternalServerError();
            }

            return RedirectToAction("Details", new { appointmentId = model.Appointment.Id });
        }

        public IActionResult Details(int appointmentId)
        {
            var model = new AppointmentDetailsModel
            {
                Appointment = _appointmentsService.GetAppointmentById(appointmentId)
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
