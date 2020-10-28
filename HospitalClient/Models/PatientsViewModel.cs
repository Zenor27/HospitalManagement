using HospitalEntities.Models;
using System.Collections.Generic;

namespace HospitalClient.Models
{
    public class PatientsViewModel
    {
        public ICollection<Patient> Patients { get; set; }
        public AddPatientViewModel AddPatientViewModel { get; set; }
        public bool OpenAddPatientModal { get; set; }
    }
}
