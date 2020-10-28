using HospitalEntities;
using HospitalEntities.Models;
using Microsoft.EntityFrameworkCore;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalTests
{
    /*
     * This class replace the database for the testing
     */
    class Database
    {
        private readonly Fixtures _fixtures;

        public Staff MainStaff
        {
            get
            {
                return _fixtures.Staffs.FirstOrDefault(s => s.Id == 1);
            }
        }

        public DbSet<User> UsersDbSet
        {
            get
            {
                var users = new List<User>();
                users.AddRange(_fixtures.Staffs);
                users.AddRange(_fixtures.Patients);
                return GetMockDbSet(users);
            }
        }

        public DbSet<Staff> StaffsDbSet => GetMockDbSet(_fixtures.Staffs);


        public DbSet<Patient> PatientsDbSet => GetMockDbSet(_fixtures.Patients);

        public DbSet<Appointment> AppointmentsDbSet => GetMockDbSet(_fixtures.Appointments);

        public Database()
        {
            _fixtures = new Fixtures();
        }

        private DbSet<T> GetMockDbSet<T>(List<T> sourceList) where T : class, IIdentifiable<int>
        {
            var queryable = sourceList.AsQueryable();

            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());
            dbSet.Setup(m => m.AsQueryable()).Returns(queryable);

            dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>(sourceList.Add);

            return dbSet.Object;
        }
    }
}
