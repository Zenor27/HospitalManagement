using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using HospitalEntities.Models;
using HospitalServer.Dto;
using HospitalServer.Repositories;
using HospitalServer.Requests;

namespace HospitalServer.Services
{
    public class AppointmentsService : IAppointmentsService
    {
        private readonly IRepository<Appointment> _appointmentRepository;
        private readonly IRepository<Patient> _patientRepository;
        private readonly IRepository<Staff> _staffRepository;

        public AppointmentsService(IRepository<Appointment> appointmentRepository, IRepository<Patient> patientRepository, IRepository<Staff> staffRepository)
        {
            _appointmentRepository = appointmentRepository;
            _patientRepository = patientRepository;
            _staffRepository = staffRepository;
        }

        public AppointmentsService(ApplicationDatabaseContext context)
        {
            _appointmentRepository = new Repository<Appointment>(context);
            _patientRepository = new Repository<Patient>(context);
            _staffRepository = new Repository<Staff>(context);
        }

        public AppointmentsService() : this(new ApplicationDatabaseContext()) { }

        /*
         * Return the list of appointments
         * for a specific staff member
         */
        private IEnumerable<Appointment> GetCurrentStaffAppointments(int staffId)
        {
            return _appointmentRepository.GetAll(x => x.Staff, x => x.Patient)
                                         .Where(appointment => appointment.Staff.Id == staffId);
        }

        /*
         * Return the list of
         * the current staff
         * todays appointments
         */
        public IEnumerable<Appointment> GetTodaysAppointments(UserTypeEnum userType, int id)
        {
            var predicate = GetAppointmentIdPredicate(userType, id);
            return _appointmentRepository.GetAll(predicate, x => x.Staff, x => x.Patient)
                .Where(appointment => appointment.Date.Date == DateTime.Today)
                .Where(appointment => appointment.Status == Status.ACCEPTED)
                .OrderBy(appointment => appointment.Date);
        }

        /// <summary>
        /// Returns all appointments of a user.
        /// </summary>
        /// <param name="id">The id of the user</param>
        /// <returns></returns>
        public IEnumerable<Appointment> GetAllAppointmentsIncludingPatientAndStaff(UserTypeEnum userType, int id)
        {
            return _appointmentRepository.GetAll(GetAppointmentIdPredicate(userType, id), a => a.Patient, a => a.Staff);
        }

        /*
         * Return a specific appointment
         * by its id
         */
        public Appointment GetAppointmentById(int appointmentId)
        {
            return _appointmentRepository.GetById(a => a.Id == appointmentId, a => a.Patient, a => a.Staff);
        }

        /*
         * Adds a appointment. Returns null if adding succeeded.
         */
        public ResponseErrorEnum? AddAppointment(AddAppointmentRequest request)
        {
            try
            {
                var alreadyHasAppointment = _appointmentRepository.Exists(a => a.StaffId == request.StaffId && a.Date == request.Date);
                if (alreadyHasAppointment)
                {
                    return ResponseErrorEnum.StaffAlreadyHasAppointmentOnDateTime;
                }

                var appointmentStatus = request.CreatorUserType == UserTypeEnum.PATIENT ? Status.WAIT : Status.ACCEPTED;

                var appointment = new Appointment
                {
                    PatientId = request.PatientId,
                    StaffId = request.StaffId,
                    CreatedAt = DateTime.Now,
                    Date = request.Date,
                    Description = request.Description,
                    Status = appointmentStatus
                };

                _appointmentRepository.Insert(appointment);
                _appointmentRepository.Save();
            }
            catch
            {
                // TODO: Log the exception.
                return ResponseErrorEnum.RepositoryError;
            }

            return null;
        }

        /*
         * Update an appointment. Returns if update succeeded.
         */
        public bool UpdatePatientBackgroundAndAppointmentDescription(int appointmentId, string patientBackground, string appointmentDescription)
        {
            try
            {
                // Fetch objects
                Appointment appointment = _appointmentRepository.GetById(a => a.Id == appointmentId, a => a.Patient);
                Patient patient = _patientRepository.GetById(p => p.Id == appointment.Patient.Id);

                // Update patient
                patient.Background = patientBackground;
                _patientRepository.Update(patient);

                // Update appointment
                appointment.Description = appointmentDescription;
                _appointmentRepository.Update(appointment);

                // Save
                _patientRepository.Save();
                _appointmentRepository.Save();
            }
            catch
            {
                return false;
            }
            return true;
        }

        public IEnumerable<Appointment> GetWaitingAppointments(UserTypeEnum userType, int id)
        {
            var predicate = GetAppointmentIdPredicate(userType, id);
            return _appointmentRepository.GetAll(predicate, a => a.Staff, a => a.Patient).Where(a => a.Status == Status.WAIT);
        }

        public IEnumerable<Appointment> GetAcceptedAppointments(UserTypeEnum userType, int id)
        {
            var predicate = GetAppointmentIdPredicate(userType, id);
            return _appointmentRepository.GetAll(predicate, a => a.Staff, a => a.Patient).Where(a => a.Status == Status.ACCEPTED);
        }

        public IEnumerable<Appointment> GetRefusedAppointments(UserTypeEnum userType, int id)
        {
            var predicate = GetAppointmentIdPredicate(userType, id);
            return _appointmentRepository.GetAll(predicate, a => a.Staff, a => a.Patient).Where(a => a.Status == Status.REFUSED);
        }

        public void AcceptAppointment(int appointmentId)
        {
            var appointment = _appointmentRepository.GetById(appointmentId);
            appointment.Status = Status.ACCEPTED;

            _appointmentRepository.Update(appointment);
            _appointmentRepository.Save();
        }

        public void RefuseAppointment(int appointmentId)
        {
            var appointment = _appointmentRepository.GetById(appointmentId);
            appointment.Status = Status.REFUSED;

            _appointmentRepository.Update(appointment);
            _appointmentRepository.Save();
        }

        private static Expression<Func<Appointment, bool>> GetAppointmentIdPredicate(UserTypeEnum userType, int id)
        {
            Expression<Func<Appointment, bool>> predicate;
            switch (userType)
            {
                case UserTypeEnum.STAFF:
                    predicate = a => a.StaffId == id;
                    break;
                case UserTypeEnum.PATIENT:
                    predicate = a => a.PatientId == id;
                    break;
                default:
                    return null;
            }

            return predicate;
        }
    }
}
