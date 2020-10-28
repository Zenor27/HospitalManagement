using Microsoft.AspNetCore.Mvc;
using HospitalEntities.Models;
using HospitalClient.Models;
using PatientService;
using Microsoft.AspNetCore.Authorization;
using System;
using LoginService;
using HospitalClient.Utils;
using HospitalClient.Extensions;

namespace HospitalClient.Controllers
{
    [Authorize(UserRole.STAFF)]
    public class PatientsController : ControllerBase
    {
        private readonly IPatientService _patientClient;
        private readonly ILoginService _loginClient;

        public PatientsController(IPatientService patientClient, ILoginService loginClient)
        {
            _patientClient = patientClient;
            _loginClient = loginClient;
        }

        public IActionResult Index()
        {
            var model = new PatientsViewModel()
            {
                Patients = _patientClient.GetPatients(),
                AddPatientViewModel = new AddPatientViewModel()
            };
            return View(model);
        }

        public IActionResult Details(int patientId)
        {
            var model = new PatientDetailsModel
            {
                Patient = _patientClient.GetPatientById(patientId)
            };
            return View(model);
        }

        public IActionResult UpdatePatientBackground(PatientDetailsModel model)
        {
            var succeded = _patientClient.UpdateBackground(model.Patient.Id, model.Patient.Background);
            if (!succeded)
            {
                throw new NotImplementedException();
            }

            return RedirectToAction("Details", new { patientId = model.Patient.Id });
        }

        [HttpPost]
        public IActionResult AddPatient(AddPatientViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            var succeeded = _loginClient.Signup(model.Email, Password.Hash(model.Password), model.FirstName, model.LastName, model.Address, model.PhoneNumber, model.Background);
            if (!succeeded)
            {
                return this.InternalServerError();
            }

            return RedirectToAction("Index");
        }
    }
}