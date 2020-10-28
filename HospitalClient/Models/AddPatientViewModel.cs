using System.ComponentModel.DataAnnotations;

namespace HospitalClient.Models
{
    public class AddPatientViewModel
    {
        // Posted Data
        [Required]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }

        public string Background { get; set; }
    }
}