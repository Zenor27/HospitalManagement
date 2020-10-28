using System;
using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using HospitalClient.Models;
using HospitalEntities.Models;
using AppointmentsService;
using HospitalClient.Extensions;
using HospitalServer.Dto;
using HospitalServer.Requests;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Razor.TagHelpers;
using StaffService;

namespace HospitalClient.Controllers
{
    [Authorize]
    public class RequestsController : ControllerBase
    {
        private readonly IAppointmentsService _appointmentsService;
        private readonly IStaffService _staffService;

        public RequestsController(IAppointmentsService appointmentsService, IStaffService staffService)
        {
            _appointmentsService = appointmentsService;
            _staffService = staffService;
        }

        public IActionResult Index()
        {
            var model = CreateRequestsViewModel();
            return View(model);
        }

        [HttpPost]
        [Authorize(UserRole.STAFF)]
        public IActionResult Accept(int appointmentId)
        {
            _appointmentsService.AcceptAppointment(appointmentId);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Authorize(UserRole.STAFF)]
        public IActionResult Refuse(int appointmentId)
        {
            _appointmentsService.RefuseAppointment(appointmentId);
            return RedirectToAction("Index");
        }

        public IActionResult AddRequest(AddRequestViewModel model)
        {
            if (ModelState.IsValid)
            {
                Debug.Assert(model.Date != null, "model.Date != null");
                Debug.Assert(model.Time != null, "model.Time != null");
                var appointmentDateTime = model.Date.Value.Date + model.Time.Value.TimeOfDay;

                var error =_appointmentsService.AddAppointment(new AddAppointmentRequest
                {
                    StaffId = model.DoctorId,
                    CreatorUserType = UserTypeEnum.PATIENT,
                    PatientId = CurrentUserId,
                    Description = model.Description,
                    Date = appointmentDateTime,
                    CreatedAt = DateTime.Now
                });

                switch (error)
                {
                    case null:
                        return RedirectToAction("Index");

                    case ResponseErrorEnum.StaffAlreadyHasAppointmentOnDateTime:
                        ModelState.AddModelError(nameof(model.DoctorId), "The doctor already has an appointment at this time.");
                        break;

                    case ResponseErrorEnum.RepositoryError:
                        return this.InternalServerError();
                }
            }

            var indexModel = CreateRequestsViewModel(model);
            return View("Index", indexModel);
        }

        private RequestsViewModel CreateRequestsViewModel(AddRequestViewModel addRequestViewModel = null)
        {
            var model = new RequestsViewModel();

            model.AppointmentsWait = _appointmentsService.GetWaitingAppointments(CurrentUserType, CurrentUserId);
            model.AppointmentsAccepted = _appointmentsService.GetAcceptedAppointments(CurrentUserType, CurrentUserId);
            model.AppointmentsRefused = _appointmentsService.GetRefusedAppointments(CurrentUserType, CurrentUserId);
            model.CanAcceptOrRefuseAppointments = IsCurrentUserStaff;

            if (addRequestViewModel != null)
            {
                model.AddRequestViewModel = addRequestViewModel;
                model.OpenAddRequestModal = true;
            }
            model.AddRequestViewModel.Doctors = _staffService.GetStaffs();

            return model;
        }
    }
}