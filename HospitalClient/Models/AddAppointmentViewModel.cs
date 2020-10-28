using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HospitalEntities.Models;

namespace HospitalClient.Models
{
    public class AddAppointmentViewModel
    {
        public ICollection<Patient> Patients { get; set; }
        public ICollection<Staff> Doctors { get; set; }

        // Posted Data
        [Required]
        public int PatientId { get; set; }
        public string PatientBackground { get; set; }
        [Required]
        [PresentOrFutureDate]
        [DataType(DataType.Date)]
        public DateTime? Date { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime? Time { get; set; }
        [Required]
        public int DoctorId { get; set; }
        public string Description { get; set; }
    }
}