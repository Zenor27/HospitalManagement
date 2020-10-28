using HospitalEntities;
using HospitalEntities.Models;
using Microsoft.EntityFrameworkCore;

namespace HospitalServer.Repositories
{
    public class Seeder
    {
        private readonly ModelBuilder _modelBuilder;
        private readonly Fixtures _fixtures;

        public Seeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
            _fixtures = new Fixtures();
        }

        private void SeedStaffs()
        {
            foreach (var staff in _fixtures.Staffs)
            {
                _modelBuilder.Entity<Staff>().HasData(staff);
            }
        }

        private void SeedPatients()
        {
            foreach (var patient in _fixtures.Patients)
            {
                _modelBuilder.Entity<Patient>().HasData(patient);
            }
        }

        private void SeedAppointments()
        {
            foreach (var appointment in _fixtures.Appointments)
            {
                _modelBuilder.Entity<Appointment>().HasData(new
                {
                    appointment.Id,
                    StaffId = appointment.Staff.Id,
                    PatientId = appointment.Patient.Id,
                    appointment.Description,
                    appointment.Date,
                    appointment.Status,
                    appointment.CreatedAt
                });
            }
        }

        private void SeedMessages()
        {
            foreach (var message in _fixtures.Messages)
            {
                _modelBuilder.Entity<Message>().HasData(message);
            }
        }

        public void Seed()
        {
            SeedStaffs();
            SeedPatients();
            SeedAppointments();
            SeedMessages();
        }
    }
}