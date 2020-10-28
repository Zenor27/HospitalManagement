using System.Collections.Generic;
using System.ServiceModel;
using HospitalEntities.Models;

namespace HospitalServer.Services
{
    [ServiceContract]
    public interface IPatientService
    {
        [OperationContract]
        IEnumerable<Patient> GetPatients();

        [OperationContract]
        Patient GetPatientById(int patientId);

        [OperationContract]
        bool UpdateBackground(int id, string background);
    }
}
