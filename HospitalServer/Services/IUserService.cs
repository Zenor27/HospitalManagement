﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using HospitalServer.Dto;
using HospitalServer.Requests;

namespace HospitalServer.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IUserService" in both code and config file together.
    [ServiceContract]
    public interface IUserService
    {
        [OperationContract]
        ResponseErrorEnum? UpdateProfile(UpdateProfileRequest request);
    }
}
