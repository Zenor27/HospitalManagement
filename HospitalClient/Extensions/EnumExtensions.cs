using System;
using System.ComponentModel;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace HospitalClient.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                .GetName();
        }

        public static string GetDescription(this Enum enumValue)
        {
            return enumValue.GetType()
                .GetMember(enumValue.ToString())
                .First()
                .GetCustomAttribute<DescriptionAttribute>()
                .Description;
        }

        public static T FindValueWithDescription<T>(string description) where T : Enum
        {
            return Enum.GetValues(typeof(T)).Cast<T>().First(enumValue => enumValue.GetDescription() == description);
        }
    }
}
