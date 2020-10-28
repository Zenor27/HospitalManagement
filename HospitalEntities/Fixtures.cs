using HospitalEntities.Models;
using System;
using System.Collections.Generic;

namespace HospitalEntities
{
    public class Fixtures
    {
        public List<Appointment> Appointments;
        public List<Message> Messages;
        public List<Patient> Patients;
        public List<Staff> Staffs;

        private readonly string _password;

        public Fixtures()
        {
            // Password is toto
            _password = "$2a$11$2OH5uKoCes87krGa.lwz2eMIy0t5rxIaUVkcBpT6ziJsHcvUnJQWK";

            CreateMessages();
            CreateStaffs();
            CreatePatients();
            CreateAppointments();
        }

        private void CreateStaffs()
        {
            Staffs = new List<Staff>
            {
                new Staff
                {
                    Id = 1,
                    Email = "antoine@fail.com",
                    PasswordHash = _password,
                    FirstName = "Antoine",
                    LastName = "Lastname",
                    StaffType = StaffType.DOCTOR,
                    Address = "14 Rue de Villejuif, 94800 Villejuif",
                    PhoneNumber = "0707070707",
                    CreatedAt = DateTime.Now
                },
                 new Staff
                {
                    Id = 2,
                    Email = "gauthier@fail.com",
                    PasswordHash = _password,
                    FirstName = "Gauthier",
                    LastName = "Lastname",
                    StaffType = StaffType.DOCTOR,
                    Address = "14 Rue de Villejuif, 94800 Villejuif",
                    PhoneNumber = "0707070707",
                    CreatedAt = DateTime.Now
                },
                new Staff
                {
                    Id = 3,
                    Email = "julien@fail.com",
                    PasswordHash = _password,
                    FirstName = "Julien",
                    LastName = "Lastname",
                    StaffType = StaffType.SPECIALIZED_DOCTOR,
                    Address = "14 Rue de Villejuif, 94800 Villejuif",
                    PhoneNumber = "0707070707",
                    CreatedAt = DateTime.Now
                },
                new Staff
                {
                    Id = 4,
                    Email = "louis@fail.com",
                    PasswordHash = _password,
                    FirstName = "Louis",
                    LastName = "Lastname",
                    StaffType = StaffType.ADMINISTRATION,
                    Address = "14 Rue de Villejuif, 94800 Villejuif",
                    PhoneNumber = "0707070707",
                    CreatedAt = DateTime.Now
                },
                new Staff
                {
                    Id = 5,
                    Email = "albert@fail.com",
                    PasswordHash = _password,
                    FirstName = "Albert",
                    LastName = "Login",
                    StaffType = StaffType.MISC,
                    Address = "14 Rue de Villejuif, 94800 Villejuif",
                    PhoneNumber = "0707070707",
                    CreatedAt = DateTime.Now
                }
            };
        }

        private void CreatePatients()
        {
            Patients = new List<Patient>
            {
                new Patient
                {
                    Id = 6,
                    Email = "denis@fail.com",
                    PasswordHash = _password,
                    FirstName = "Denis",
                    LastName = "Lastname",
                    Address = "EPITA",
                    PhoneNumber = "0000000000",
                    Background = "Troubles psychologiques",
                    CreatedAt = DateTime.Now
                },
                new Patient
                {
                    Id = 7,
                    Email = "sylvie@fail.com",
                    PasswordHash = _password,
                    FirstName = "Sylvie",
                    LastName = "Lastname",
                    Address = "EPITA",
                    PhoneNumber = "0000000000",
                    Background = "Troubles psychologiques",
                    CreatedAt = DateTime.Now
                },
                new Patient
                {
                    Id = 8,
                    Email = "login@fail.com",
                    PasswordHash = _password,
                    FirstName = "Antoine",
                    LastName = "Login",
                    Address = "EPITA",
                    PhoneNumber = "0000000000",
                    Background = "Troubles psychologiques",
                    CreatedAt = DateTime.Now
                },
                new Patient
                {
                    Id = 9,
                    Email = "xavier@fail.com",
                    PasswordHash = _password,
                    FirstName = "Xavier",
                    LastName = "Login",
                    Address = "EPITA",
                    PhoneNumber = "0000000000",
                    Background = "Troubles psychologiques",
                    CreatedAt = DateTime.Now
                }
            };
        }

        private void CreateMessages()
        {
            Messages = new List<Message> {
                new Message
                {
                    Id = 1,
                    Description = "Alerte COVID-19. Restez prudent.",
                    CreatedAt = DateTime.Now
                },
                new Message
                {
                    Id = 2,
                    Description = "Portez des masques. Restez prudent.",
                    CreatedAt = DateTime.Now
                }
            };
        }

        private void CreateAppointments()
        {
            Appointments = new List<Appointment>
            {
                new Appointment
                {
                    Id = 1,
                    Staff = Staffs[0],
                    Patient = Patients[0],
                    Description = "Rendez-Vous classique",
                    Date = DateTime.Now,
                    Status = Status.ACCEPTED,
                    CreatedAt = DateTime.Now
                },
                new Appointment
                {
                    Id = 2,
                    Staff = Staffs[0],
                    Patient = Patients[0],
                    Description = "Rendez-Vous classique",
                    Date = DateTime.Now,
                    Status = Status.WAIT,
                    CreatedAt = DateTime.Now
                },
                new Appointment
                {
                    Id = 3,
                    Staff = Staffs[0],
                    Patient = Patients[1],
                    Description = "Rendez-Vous classique",
                    Date = DateTime.Now,
                    Status = Status.REFUSED,
                    CreatedAt = DateTime.Now
                },
                new Appointment
                {
                    Id = 4,
                    Staff = Staffs[1],
                    Patient = Patients[1],
                    Description = "Rendez-Vous classique",
                    Date = DateTime.Now,
                    Status = Status.ACCEPTED,
                    CreatedAt = DateTime.Now
                },
                new Appointment
                {
                    Id = 5,
                    Staff = Staffs[1],
                    Patient = Patients[2],
                    Description = "Rendez-Vous classique",
                    Date = DateTime.Now,
                    Status = Status.WAIT,
                    CreatedAt = DateTime.Now
                }
            };

            foreach (var appointment in Appointments)
            {
                appointment.StaffId = appointment.Staff.Id;
                appointment.PatientId = appointment.Patient.Id;
            }
        }
    }
}
