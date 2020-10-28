using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace HospitalServer.Dto
{
    [DataContract]
    public enum ResponseErrorEnum
    {
        [EnumMember]
        RepositoryError,
        [EnumMember]
        StaffAlreadyHasAppointmentOnDateTime,
        [EnumMember]
        EmailAlreadyUsed,
        [EnumMember]
        EmptyInput
    }
}