using HospitalEntities.Models;

namespace HospitalServer.Dto
{
    public class LoginResponse
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public UserTypeEnum UserType { get; set; }
    }
}