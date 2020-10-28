using System.ComponentModel;

namespace HospitalEntities.Models
{
    public static class UserRole
    {
        public const string STAFF = nameof(Staff);
        public const string PATIENT = nameof(Patient);
    }

    public enum UserTypeEnum
    {
        [Description(UserRole.STAFF)]
        STAFF,
        [Description(UserRole.PATIENT)]
        PATIENT
    }
}