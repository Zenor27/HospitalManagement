using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using HospitalEntities.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace HospitalClient.Models
{
    public class AddStaffViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public StaffType? StaffType { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        public string Address { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }
    }
}