using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalEntities.Models
{
    /*
     * Model for a Patient
     */
    public class Patient : User
    {
        public string Background { get; set; }
    }
}