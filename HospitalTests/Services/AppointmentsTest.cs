using System;
using System.Linq;
using HospitalEntities.Models;
using HospitalServer.Dto;
using HospitalServer.Repositories;
using HospitalServer.Requests;
using HospitalServer.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace HospitalTests.Services
{
    [TestClass]
    public class AppointmentsTest : BaseTest
    {
        private AppointmentsService appointmentsService;

        [TestInitialize]
        public void SetUp()
        {
            BaseSetup();
            appointmentsService = new AppointmentsService(contextMock.Object);
        }

        [TestMethod]
        public void GetAllAppointmentsIncludingPatientAndStaff()
        {
            var appointments = appointmentsService.GetAllAppointmentsIncludingPatientAndStaff(UserTypeEnum.STAFF, 1).ToList();
            Assert.AreEqual(3, appointments.Count);
            CollectionAssert.AllItemsAreNotNull(appointments.Select(a => a.Patient).ToList());
            CollectionAssert.AllItemsAreNotNull(appointments.Select(a => a.Staff).ToList());
        }

        [TestMethod]
        public void GetAppointmentById_ReturnsNullWhenNotFound()
        {
            var appointment = appointmentsService.GetAppointmentById(0);
            Assert.IsNull(appointment);
        }

        [TestMethod]
        public void GetAppointmentById()
        {
            const int id = 1;
            var appointment = appointmentsService.GetAppointmentById(1);
            Assert.AreEqual(id, appointment.Id);
        }

        [TestMethod]
        public void AddAppointment_ReturnsErrorIfStaffAlreadyHasAppointmentAtSameTime()
        {
            var appointment = contextMock.Object.Appointments.First();
            var error = appointmentsService.AddAppointment(new AddAppointmentRequest
            {
                PatientId = appointment.PatientId,
                Description = appointment.Description,
                CreatorUserType = UserTypeEnum.STAFF,
                Date = appointment.Date,
                StaffId = appointment.StaffId,
                CreatedAt = appointment.CreatedAt
            });
            Assert.AreEqual(ResponseErrorEnum.StaffAlreadyHasAppointmentOnDateTime, error);
        }

        [TestMethod]
        public void AddAppointment_ReturnsNullWhenSuccessful()
        {
            var datetime = new DateTime(2020, 04, 27, 12, 30, 00);
            var error = appointmentsService.AddAppointment(new AddAppointmentRequest
            {
                PatientId = contextMock.Object.Patients.First().Id,
                StaffId = contextMock.Object.Staffs.First().Id,
                CreatedAt = datetime,
                Date = datetime.AddDays(1),
                Description = "DESCRIPTION",
                CreatorUserType = UserTypeEnum.STAFF,
            });
            Assert.IsNull(error);
        }

        [TestMethod]
        public void UpdatePatientBackgroundAndAppointmentDescription_ReturnsFalseWhenNotFound()
        {
            const int id = 0;
            const string background = "BACKGROUND";
            const string description = "DESCRIPTION";
            var succeeded = appointmentsService.UpdatePatientBackgroundAndAppointmentDescription(id, background, description);
            Assert.IsFalse(succeeded);
        }

        [TestMethod]
        public void UpdatePatientBackgroundAndAppointmentDescription()
        {
            Mock<Repository<T>> MockRepository<T>() where T : class, IIdentifiable
            {
                var mock = new Mock<Repository<T>>(contextMock.Object);
                mock.Setup(r => r.SetStateModified(It.IsAny<T>()));
                return mock;
            }

            const int id = 1;
            const string background = "BACKGROUND";
            const string description = "DESCRIPTION";
            var patientRepository = MockRepository<Patient>();
            var appointmentRepository = MockRepository<Appointment>();
            var service = new AppointmentsService(appointmentRepository.Object, patientRepository.Object, null);
            var succeeded = service.UpdatePatientBackgroundAndAppointmentDescription(id, background, description);
            var appointment = contextMock.Object.Appointments.First(a => a.Id == id);
            var patient = appointment.Patient;
            Assert.IsTrue(succeeded);
            Assert.AreEqual(description, appointment.Description);
            Assert.AreEqual(background, patient.Background);
        }

        [TestMethod]
        public void GetStaffWaitingAppointmentsTest()
        {
            var appointments = appointmentsService.GetWaitingAppointments(UserTypeEnum.STAFF, _currentStaff.Id);
            Assert.AreEqual(appointments.Count(), 1);
        }

        [TestMethod]
        public void GetStaffAcceptedAppointmentsTest()
        {
            var appointments = appointmentsService.GetAcceptedAppointments(UserTypeEnum.STAFF, _currentStaff.Id);
            Assert.AreEqual(appointments.Count(), 1);
        }

        [TestMethod]
        public void GetStaffRefusedAppointmentsTest()
        {
            var appointments = appointmentsService.GetRefusedAppointments(UserTypeEnum.STAFF, _currentStaff.Id);
            Assert.AreEqual(appointments.Count(), 1);
        }

        [TestMethod]
        public void AcceptAppointmentTest()
        {
            Mock<Repository<T>> MockRepository<T>() where T : class, IIdentifiable
            {
                var mock = new Mock<Repository<T>>(contextMock.Object);
                mock.Setup(r => r.SetStateModified(It.IsAny<T>()));
                return mock;
            }


            var appointmentRepository = MockRepository<Appointment>();
            var service = new AppointmentsService(appointmentRepository.Object, null, null);

            var appointment = service.GetWaitingAppointments(UserTypeEnum.STAFF, _currentStaff.Id).ElementAt(0);
            service.AcceptAppointment(appointment.Id);
            appointment = service.GetAppointmentById(appointment.Id);
            Assert.AreEqual(appointment.Status, Status.ACCEPTED);
        }

        [TestMethod]
        public void RefuseAppointmentTest()
        {
            Mock<Repository<T>> MockRepository<T>() where T : class, IIdentifiable
            {
                var mock = new Mock<Repository<T>>(contextMock.Object);
                mock.Setup(r => r.SetStateModified(It.IsAny<T>()));
                return mock;
            }


            var appointmentRepository = MockRepository<Appointment>();
            var service = new AppointmentsService(appointmentRepository.Object, null, null);

            var appointment = service.GetWaitingAppointments(UserTypeEnum.STAFF, _currentStaff.Id).ElementAt(0);
            service.RefuseAppointment(appointment.Id);
            appointment = service.GetAppointmentById(appointment.Id);
            Assert.AreEqual(appointment.Status, Status.REFUSED);
        }
    }
}
