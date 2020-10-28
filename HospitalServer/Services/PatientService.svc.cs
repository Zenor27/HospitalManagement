using System.Collections.Generic;
using HospitalEntities.Models;
using HospitalServer.Repositories;

namespace HospitalServer.Services
{
    public class PatientService : IPatientService
    {
        private readonly IRepository<Patient> _patientRepository;

        public PatientService(IRepository<Patient> patientRepository)
        {
            _patientRepository = patientRepository;
        }

        public PatientService() : this(new Repository<Patient>(new ApplicationDatabaseContext()))
        {

        }

        /**
         * Returns all patients.
         */
        public IEnumerable<Patient> GetPatients()
        {
            return _patientRepository.GetAll();
        }

        public bool UpdateBackground(int id, string background)
        {
            try
            {
                var patient = _patientRepository.GetById(id);
                patient.Background = background;
                _patientRepository.Save();
            }
            catch
            {
                // TODO: Log exception.
                return false;
            }

            return true;
        }

        public Patient GetPatientById(int patientId)
        {
            return _patientRepository.GetById(patientId);
        }
    }
}
