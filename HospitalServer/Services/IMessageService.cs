using System.Collections.Generic;
using System.ServiceModel;
using HospitalEntities.Models;
using HospitalServer.Dto;

namespace HospitalServer.Services
{
    [ServiceContract]
    public interface IMessageService
    {
        [OperationContract]
        IEnumerable<Message> GetLastMessages();

        [OperationContract]
        ResponseErrorEnum? AddMessage(string description);

        [OperationContract]
        IEnumerable<Message> GetMessages();
    }
}
