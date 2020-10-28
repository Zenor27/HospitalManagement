using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HospitalEntities.Models;

namespace HospitalClient.Models
{
    public class AddRequestViewModel
    {
        public ICollection<Staff> Doctors { get; set; }

        // Posted Data
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