using System;
using HospitalEntities.Models;

namespace HospitalServer.Requests
{
    public class AddAppointmentRequest
    {
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public int StaffId { get; set; }
        public int PatientId { get; set; }
        public UserTypeEnum CreatorUserType { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}