using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HospitalEntities.Models
{
    /*
     * Staff Type Enumeration
     */
    public enum StaffType
    {
        [Display(Name = "Docteur")]
        DOCTOR,
        [Display(Name = "Docteur Spécialisé")]
        SPECIALIZED_DOCTOR,
        [Display(Name = "Administration")]
        ADMINISTRATION,
        [Display(Name = "Autre")]
        MISC
    }

    /*
     * Model of a staff
     */
    public class Staff : User
    {
        [Required]
        public StaffType StaffType { get; set; }
    }
}