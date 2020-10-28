using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEntities.Models
{
    /*
     * Enumeration for Appointment status
     */
    public enum Status
    {
        ACCEPTED,
        REFUSED,
        WAIT
    }

    /*
     * Model for an Appointment
     */
    public class Appointment : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Staff Staff { get; set; }

        [Required]
        public Patient Patient { get; set; }

        public string Description { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public Status Status { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int StaffId { get; set; }

        [Required]
        public int PatientId { get; set; }
    }
}