﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalServer.Requests
{
    public class UpdateProfileRequest
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}