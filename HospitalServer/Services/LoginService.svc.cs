using System;
using System.Linq;
using HospitalEntities.Models;
using HospitalServer.Dto;
using HospitalServer.Repositories;

namespace HospitalServer.Services
{
    public class LoginService : ILoginService
    {
        private readonly IRepository<User> _userRepository;
        private readonly IRepository<Staff> _staffRepository;
        private readonly IRepository<Patient> _patientRepository;

        public LoginService(ApplicationDatabaseContext context)
        {
            _userRepository = new Repository<User>(context);
            _staffRepository = new Repository<Staff>(context);
            _patientRepository = new Repository<Patient>(context);
        }

        public LoginService() : this(new ApplicationDatabaseContext()) { }

        public LoginResponse Login(string email, string password)
        {
            var user = _userRepository.GetAll()
                .FirstOrDefault(s => s.Email == email && BCrypt.Net.BCrypt.Verify(password, s.PasswordHash));

            if (user != null)
            {
                return new LoginResponse
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    UserId = user.Id,
                    UserType = user.UserType
                };
            }

            return null;
        }

        /*
         * Create a new patient
         * New Staff can be added in app
         */
        public bool Signup(string email, string password, string firstName, string lastName, string address = null, string phoneNumber = null, string background = null)
        {
            var alreadyExists = _userRepository.GetAll().FirstOrDefault(user => user.Email == email) != null;
            if (alreadyExists)
                return false;

            _patientRepository.Insert(new Patient
            {
                Email = email,
                PasswordHash = password,
                FirstName = firstName,
                LastName = lastName,
                Address = address,
                PhoneNumber = phoneNumber,
                Background = background,
                CreatedAt = DateTime.Now
            });
            _patientRepository.Save();
            return true;
        }
    }
}
