using HospitalEntities.Models;

namespace HospitalServer.Requests
{
    public class AddStaffRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public StaffType StaffType { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
    }
}