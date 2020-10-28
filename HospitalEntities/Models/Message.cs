using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEntities.Models
{
    /*
     * Model for a Message
     */
    public class Message : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }
    }
}