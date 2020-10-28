using HospitalServer.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Globalization;
using HospitalEntities.Models;

namespace HospitalTests.Services
{
    [TestClass]
    public class StatisticsServiceTest : BaseTest
    {
        private StatisticsService _statisticsService;
        private UserTypeEnum _userType;

        [TestInitialize()]
        public void SetUp()
        {
            BaseSetup();
            _statisticsService = new StatisticsService(contextMock.Object);
            _userType = UserTypeEnum.STAFF;
        }


        [TestMethod]
        public void GetTotalAppointmentsTest()
        {
            Assert.AreEqual(_statisticsService.GetTotalAppointments(_userType, _currentStaff.Id), 1);
        }

        [TestMethod]
        public void GetNewAppointmentsIn24HoursTest()
        {
            Assert.AreEqual(_statisticsService.GetNewAppointmentsIn24Hours(_userType, _currentStaff.Id), 1);
        }

        [TestMethod]
        public void GetComingNextAppointmentsNumberTest()
        {
            Assert.AreEqual(_statisticsService.GetComingNextAppointmentsNumber(_userType, _currentStaff.Id), 0);
        }

        [TestMethod]
        public void GetComingNextAppointmentTest()
        {
            Assert.IsNull(_statisticsService.GetComingNextAppointment(_userType, _currentStaff.Id));
        }

        [TestMethod]
        public void GetAvailableDoctorsNumberTest()
        {
            Assert.AreEqual(_statisticsService.GetAvailableDoctorsNumber(), 1);
        }

        [TestMethod]
        public void GetLast24HoursAvailableDoctorsTest()
        {
            Assert.AreEqual(_statisticsService.GetLast24HoursAvailableDoctors(), -2);
        }

        [TestMethod]
        public void GetApprovalWaitingAppointmentsNumberTest()
        {
            Assert.AreEqual(_statisticsService.GetApprovalWaitingAppointmentsNumber(_userType, _currentStaff.Id), 1);
        }

        [TestMethod]
        public void GetLast24HoursWaitingAppointmentsTest()
        {
            Assert.AreEqual(_statisticsService.GetLast24HoursWaitingAppointments(_userType, _currentStaff.Id), 1);
        }

        [TestMethod]
        public void GetTotalHospitalPatientsTest()
        {
            Assert.AreEqual(_statisticsService.GetTotalHospitalPatients(), 4);
        }

        [TestMethod]
        public void GetLast24HoursNewPatientsTest()
        {
            Assert.AreEqual(_statisticsService.GetLast24HoursNewPatients(), 4);
        }

        [TestMethod]
        public void GetTodayAppointmentsNumberTest()
        {
            Assert.AreEqual(_statisticsService.GetTodayAppointmentsNumber(_userType, _currentStaff.Id), 1);
        }

        [TestMethod]
        public void GetNumberOfAppointmentsCompareToYesterday()
        {
            Assert.AreEqual(_statisticsService.GetNumberOfAppointmentsCompareToYesterday(_userType, _currentStaff.Id), 1);
        }

        [TestMethod]
        public void GetMonthAppointmentsNumberTest()
        {
            var expected = new Dictionary<string, int>();
            foreach (var month in CultureInfo.CurrentCulture.DateTimeFormat.MonthNames)
            {
                if (month == "")
                    continue;

                var value = 0;
                if (DateTime.Now.Date.ToString("MMMM", CultureInfo.CurrentCulture.DateTimeFormat) == month)
                    value = 1;

                expected.Add(month, value);
            }

            CollectionAssert.AreEqual(_statisticsService.GetMonthAppointmentsNumber(_userType, _currentStaff.Id), expected);
        }

        [TestMethod]
        public void GetHospitalMonthAppointmentsNumberTest()
        {
            var expected = new Dictionary<string, int>();
            foreach (var month in CultureInfo.CurrentCulture.DateTimeFormat.MonthNames)
            {
                if (month == "")
                    continue;

                var value = 0;
                if (DateTime.Now.Date.ToString("MMMM", CultureInfo.CurrentCulture.DateTimeFormat) == month)
                    value = 2;

                expected.Add(month, value);
            }

            var response = _statisticsService.GetHospitalMonthAppointmentsNumber();

            CollectionAssert.AreEqual(response, expected);
        }


    }
}
