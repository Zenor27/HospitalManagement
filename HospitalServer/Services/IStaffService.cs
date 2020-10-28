using HospitalEntities.Models;
using System.Collections.Generic;
using System.ServiceModel;
using HospitalServer.Dto;
using HospitalServer.Requests;

namespace HospitalServer.Services
{
    [ServiceContract]
    public interface IStaffService
    {
        [OperationContract]
        IEnumerable<Staff> GetStaffs();

        [OperationContract]
        Staff GetStaffById(int staffId);

        [OperationContract]
        ResponseErrorEnum? AddStaff(AddStaffRequest request);
    }
}
