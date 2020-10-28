using System.ComponentModel.DataAnnotations;
using HospitalEntities.Models;

namespace HospitalClient.Models
{
    public class ProfileViewModel
    {
        public User CurrentUser { get; set; }
        public UpdateProfileViewModel UpdateProfileViewModel { get; set; }
        public bool OpenUpdateProfileModal { get; set; }
    }

    public class UpdateProfileViewModel
    {
        public UpdateProfileViewModel()
        {
        }

        public UpdateProfileViewModel(ProfileViewModel model)
        {
            var currentStaff = model.CurrentUser;
            FirstName = currentStaff?.FirstName;
            LastName = currentStaff?.LastName;
            Email = currentStaff?.Email;
            PhoneNumber = currentStaff?.PhoneNumber;
            Address = currentStaff?.Address;
        }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
