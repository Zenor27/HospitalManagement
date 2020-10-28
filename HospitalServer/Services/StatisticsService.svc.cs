using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using HospitalEntities.Models;
using HospitalServer.Repositories;

namespace HospitalServer.Services
{
    /*
     * Statistics Service
     */
    public class StatisticsService : IStatisticsService
    {
        private readonly Repository<Appointment> _appointmentRepository;
        private readonly Repository<Staff> _staffRepository;
        private readonly Repository<Patient> _patientRepository;

        public StatisticsService(ApplicationDatabaseContext context)
        {
            _appointmentRepository = new Repository<Appointment>(context);
            _staffRepository = new Repository<Staff>(context);
            _patientRepository = new Repository<Patient>(context);
        }

        public StatisticsService() : this(new ApplicationDatabaseContext()) { }

        /*
         * Return the list of appointments
         * for a specific staff member
         */
        private IEnumerable<Appointment> GetCurrentUserAppointments(UserTypeEnum userType, int userId)
        {
            var predicate = GetAppointmentIdPredicate(userType, userId);
            return _appointmentRepository.GetAll(predicate, x => x.Staff, x => x.Patient);
        }

        /*
         * Return the number of appointments for
         * a specific staff
         */
        public int GetTotalAppointments(UserTypeEnum userType, int userId)
        {
            return GetCurrentUserAppointments(userType, userId)
                .Where(appointment => appointment.Status == Status.ACCEPTED)
                .Count();
        }

        /*
         * Return the number of new appointments
         * in the last 24 hours
         * for a specific staff
         */
        public int GetNewAppointmentsIn24Hours(UserTypeEnum userType, int userId)
        {
            var now = DateTime.Now;
            return GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.CreatedAt > now.AddHours(-24) && appointment.CreatedAt <= now)
                                                     .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                     .Count();
        }

        /*
         * Return the number of appointments
         * coming next
         */
        public int GetComingNextAppointmentsNumber(UserTypeEnum userType, int userId)
        {
            return GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.Date.TimeOfDay > DateTime.Now.TimeOfDay)
                                                     .Where(appointment => appointment.Date.Date == DateTime.Today)
                                                     .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                     .Count();
        }

        /*
         * Return the coming next
         * appointment for a specific staff
         */
        public Appointment GetComingNextAppointment(UserTypeEnum userType, int userId)
        {
            return GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.Date > DateTime.Now)
                                                     .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                     .OrderBy(appointment => appointment.Date)
                                                     .FirstOrDefault();
        }

        /*
         * Return the number of doctor
         * without appointment today
         */
        public int GetAvailableDoctorsNumber()
        {
            var staffWithAppointmentToday = _appointmentRepository.GetAll(x => x.Staff)
                                                                  .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                                  .Where(appointment => appointment.Date.Date == DateTime.Today);
            return _staffRepository.GetAll()
                                   .Where(staff => !staffWithAppointmentToday.Any(s => s.Staff.Id == staff.Id))
                                   .Where(staff => staff.StaffType == StaffType.DOCTOR || staff.StaffType == StaffType.SPECIALIZED_DOCTOR)
                                   .Count();
        }

        /*
         * Return the number of
         * available doctor in comparaison
         * with yesterday
         */
        public int GetLast24HoursAvailableDoctors()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            var staffWithAppointmentYesterday = _appointmentRepository.GetAll(x => x.Staff)
                                                                      .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                                      .Where(appointment => appointment.Date.Date == yesterday);

            var staffWithAppointmentToday = _appointmentRepository.GetAll(x => x.Staff)
                                                                  .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                                  .Where(appointment => appointment.Date.Date == DateTime.Now.Date);

            var availableDoctorsYesterday = _staffRepository.GetAll().Where(staff => !staffWithAppointmentYesterday.Any(s => s.Staff.Id == staff.Id))
                                                                     .Where(staff => staff.StaffType == StaffType.DOCTOR || staff.StaffType == StaffType.SPECIALIZED_DOCTOR)
                                                                     .Count();

            var availableDoctorsToday = _staffRepository.GetAll().Where(staff => !staffWithAppointmentToday.Any(s => s.Staff.Id == staff.Id))
                                                                     .Where(staff => staff.StaffType == StaffType.DOCTOR || staff.StaffType == StaffType.SPECIALIZED_DOCTOR)
                                                                     .Count();

            return availableDoctorsToday - availableDoctorsYesterday;
        }

        /*
         * Return number of appointments
         * waiting for response
         */
        public int GetApprovalWaitingAppointmentsNumber(UserTypeEnum userType, int userId)
        {
            return GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.Status == Status.WAIT)
                                                     .Count();
        }

        /*
         * Return the new appointments in
         * the last 24h
         */
        public int GetLast24HoursWaitingAppointments(UserTypeEnum userType, int userId)
        {
            var now = DateTime.Now;
            var newAppointmentsIn24Hours = GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.CreatedAt > now.AddHours(-24) && appointment.CreatedAt <= now)
                                                                             .Where(appointment => appointment.Status == Status.WAIT)
                                                                             .Count();
            return newAppointmentsIn24Hours;
        }

        /*
         * Return the number of
         * patients for this hospital
         */
        public int GetTotalHospitalPatients()
        {
            return _patientRepository.GetAll()
                                     .Count();
        }

        /*
         * Return the new patients
         * in the last 24hours
         */
        public int GetLast24HoursNewPatients()
        {
            var yesterday = DateTime.Today.AddDays(-1);
            return _patientRepository.GetAll()
                                     .Where(patient => patient.CreatedAt >= yesterday)
                                     .Count();
        }

        /*
         * Return the number
         * of todays appointments
         */
        public int GetTodayAppointmentsNumber(UserTypeEnum userType, int userId)
        {
            return GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.Date.Date == DateTime.Today)
                                                     .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                     .Count();
        }

        /*
         * Return the number of
         * appointments compare to yesterday
         */
        public int GetNumberOfAppointmentsCompareToYesterday(UserTypeEnum userType, int userId)
        {
            var yesterday = DateTime.Today.AddDays(-1);

            var yesterdayAppointments = GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.Date.Date == yesterday)
                                                                          .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                                          .Count();

            var todayAppointments = GetCurrentUserAppointments(userType, userId).Where(appointment => appointment.Date.Date == DateTime.Today)
                                                                      .Where(appointment => appointment.Status == Status.ACCEPTED)
                                                                      .Count();

            return todayAppointments - yesterdayAppointments;
        }

        /*
         * Return a map with key = each months
         * and value = nb of appointments
         */
        public Dictionary<string, int> GetMonthAppointmentsNumber(UserTypeEnum userType, int userId)
        {
            var monthAppointmentsNumber = new Dictionary<string, int>();

            var myAppointments = GetCurrentUserAppointments(userType, userId);

            foreach (var month in CultureInfo.CurrentCulture.DateTimeFormat.MonthNames)
            {
                if (month == "")
                    continue;

                var appointmentsNumber = myAppointments.Where(a => a.Date.ToString("MMMM", CultureInfo.CurrentCulture.DateTimeFormat) == month)
                                                       .Where(a => a.Status == Status.ACCEPTED)
                                                       .Count();
                monthAppointmentsNumber.Add(month, appointmentsNumber);
            }

            return monthAppointmentsNumber;
        }

        /*
         * Return a map with key = each months
         * and value = nb of appointments
         */
        public Dictionary<string, int> GetHospitalMonthAppointmentsNumber()
        {
            var monthAppointmentsNumber = new Dictionary<string, int>();

            var hospitalAppointments = _appointmentRepository.GetAll();

            foreach (var month in CultureInfo.CurrentCulture.DateTimeFormat.MonthNames)
            {
                if (month == "")
                    continue;

                var appointmentsNumber = hospitalAppointments.Where(a => a.Date.ToString("MMMM", CultureInfo.CurrentCulture.DateTimeFormat) == month)
                                                             .Where(a => a.Status == Status.ACCEPTED)
                                                             .Count();
                monthAppointmentsNumber.Add(month, appointmentsNumber);
            }

            return monthAppointmentsNumber;
        }

        private static Expression<Func<Appointment, bool>> GetAppointmentIdPredicate(UserTypeEnum userType, int userId)
        {
            Expression<Func<Appointment, bool>> predicate;
            switch (userType)
            {
                case UserTypeEnum.STAFF:
                    predicate = a => a.StaffId == userId;
                    break;
                case UserTypeEnum.PATIENT:
                    predicate = a => a.PatientId == userId;
                    break;
                default:
                    return null;
            }

            return predicate;

        }
    }
}
