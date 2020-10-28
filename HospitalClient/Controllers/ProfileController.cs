using HospitalClient.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using HospitalClient.Models;
using HospitalServer.Dto;
using HospitalServer.Requests;
using PatientService;
using StaffService;
using UserService;

namespace HospitalClient.Controllers
{
    [Authorize]
    public class ProfileController : ControllerBase
    {
        private readonly IStaffService _staffService;
        private readonly IPatientService _patientService;
        private readonly IUserService _userService;

        public ProfileController(IStaffService staffService, IPatientService patientService, IUserService userService)
        {
            _staffService = staffService;
            _patientService = patientService;
            _userService = userService;
        }

        public IActionResult Index()
        {
            var model = new ProfileViewModel();
            FillProfileViewModel(model);
            return View(model);
        }

        private void FillProfileViewModel(ProfileViewModel model)
        {
            if (IsCurrentUserStaff)
            {
                model.CurrentUser = _staffService.GetStaffById(CurrentUserId);
            }
            else if (IsCurrentUserPatient)
            {
                model.CurrentUser = _patientService.GetPatientById(CurrentUserId);
            }
        }

        public IActionResult UpdateProfile(UpdateProfileViewModel model)
        {
            if (ModelState.IsValid)
            {
                var error = _userService.UpdateProfile(new UpdateProfileRequest
                {
                    UserId = CurrentUserId,
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Address = model.Address,
                    PhoneNumber = model.PhoneNumber,
                    Email = model.Email
                });

                switch (error)
                {
                    case null:
                        return RedirectToAction("Index");

                    case ResponseErrorEnum.EmailAlreadyUsed:
                        ModelState.AddModelError(nameof(model.Email), "This email is already used");
                        break;

                    default:
                        return this.InternalServerError();
                }
            }

            var indexModel = new ProfileViewModel();
            FillProfileViewModel(indexModel);
            indexModel.UpdateProfileViewModel = model;
            indexModel.OpenUpdateProfileModal = true;
            return View("Index", indexModel);
        }
    }
}