using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HospitalEntities.Models;
using HospitalServer.Dto;
using HospitalServer.Repositories;
using HospitalServer.Requests;

namespace HospitalServer.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select UserService.svc or UserService.svc.cs at the Solution Explorer and start debugging.
    public class UserService : IUserService
    {
        private readonly IRepository<User> _userRepository;

        public UserService()
        {
            _userRepository = new Repository<User>(new ApplicationDatabaseContext());
        }

        /*
         * Updates the profile of a staff
         */
        public ResponseErrorEnum? UpdateProfile(UpdateProfileRequest request)
        {
            try
            {
                var isEmailAlreadyUsed = _userRepository.Exists(s => s.Id != request.UserId && s.Email == request.Email);
                if (isEmailAlreadyUsed)
                {
                    return ResponseErrorEnum.EmailAlreadyUsed;
                }

                var user = _userRepository.GetById(request.UserId);
                user.FirstName = request.FirstName;
                user.LastName = request.LastName;
                user.Email = request.Email;
                user.PhoneNumber = request.PhoneNumber;
                user.Address = request.Address;

                _userRepository.Update(user);
                _userRepository.Save();
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
