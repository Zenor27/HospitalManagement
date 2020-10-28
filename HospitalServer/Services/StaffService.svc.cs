using System;
using HospitalEntities.Models;
using HospitalServer.Repositories;
using System.Collections.Generic;
using System.Linq;
using HospitalServer.Dto;
using HospitalServer.Requests;

namespace HospitalServer.Services
{
    /*
     * Staff Service
     */
    public class StaffService : IStaffService
    {
        private readonly Repository<Staff> _staffRepository;
        public StaffService()
        {
            _staffRepository = new Repository<Staff>(new ApplicationDatabaseContext());
        }

        /*
         * Return all staffs
         */
        public IEnumerable<Staff> GetStaffs()
        {
            return _staffRepository.GetAll();
        }

        /*
         * Return a particular staff
         */
        public Staff GetStaffById(int staffId)
        {
            return _staffRepository.GetById(staffId);
        }

        public ResponseErrorEnum? AddStaff(AddStaffRequest request)
        {
            try
            {
                var staffEmails = _staffRepository.GetAll().Select(s => s.Email);
                if (staffEmails.Contains(request.Email))
                {
                    return ResponseErrorEnum.EmailAlreadyUsed;
                }

                var passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

                var staff = new Staff
                {
                    Address = request.Address,
                    CreatedAt = DateTime.Now,
                    Email = request.Email,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    PasswordHash = passwordHash,
                    PhoneNumber = request.PhoneNumber,
                    StaffType = request.StaffType
                };

                _staffRepository.Insert(staff);
                _staffRepository.Save();
            }
            catch
            {
                // TODO: Log the exception.
                return ResponseErrorEnum.RepositoryError;
            }

            return null;
        }
    }
}
