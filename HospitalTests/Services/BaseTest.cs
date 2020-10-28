using System.Collections.Generic;
using HospitalEntities.Models;
using HospitalServer.Repositories;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Moq;

namespace HospitalTests.Services
{
    public class BaseTest
    {
        protected Mock<ApplicationDatabaseContext> contextMock;
        protected Staff _currentStaff;

        protected void BaseSetup()
        {
            contextMock = new Mock<ApplicationDatabaseContext>();
            var database = new Database();
            contextMock.Setup(s => s.Set<Appointment>()).Returns(database.AppointmentsDbSet);
            contextMock.Setup(s => s.Set<Staff>()).Returns(database.StaffsDbSet);
            contextMock.Setup(s => s.Set<Patient>()).Returns(database.PatientsDbSet);
            contextMock.Setup(s => s.Set<User>()).Returns(database.UsersDbSet);

            contextMock.Setup(s => s.Appointments).Returns(database.AppointmentsDbSet);
            contextMock.Setup(s => s.Staffs).Returns(database.StaffsDbSet);
            contextMock.Setup(s => s.Patients).Returns(database.PatientsDbSet);

            _currentStaff = database.MainStaff;
        }
    }
}
