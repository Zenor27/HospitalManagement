using System.ComponentModel.DataAnnotations;

namespace HospitalClient.Models
{
    public class SignUpViewModel : LoginViewModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare(nameof(Password))]
        public string ConfirmPassword { get; set; }

        public string Address { get; set; }

        public string PhoneNumber { get; set; }
    }
}