using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEntities.Models
{
    public abstract class User : IIdentifiable
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PasswordHash { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public UserTypeEnum UserType { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}