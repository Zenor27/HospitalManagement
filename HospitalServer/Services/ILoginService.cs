using HospitalServer.Dto;
using System.ServiceModel;
using HospitalEntities.Models;

namespace HospitalServer.Services
{
    [ServiceContract]
    public interface ILoginService
    {
        [OperationContract]
        LoginResponse Login(string email, string password);

        [OperationContract]
        bool Signup(string email, string password, string firstName, string lastName, string address = null, string phoneNumber = null, string background = null);
    }
}
