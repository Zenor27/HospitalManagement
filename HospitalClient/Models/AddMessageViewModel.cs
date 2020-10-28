using System.ComponentModel.DataAnnotations;
using HospitalEntities.Models;

namespace HospitalClient.Models
{
    public class AddMessageViewModel
    {
        [Required]
        public string Description { get; set; }
    }
}