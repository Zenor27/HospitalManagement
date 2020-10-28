using System;

namespace HospitalClient.Extensions
{
    public static class DateTimeExtensions
    {
        public static string ToHtmlDateString(this DateTime dateTime)
        {
            return dateTime.ToString("yyyy-MM-dd");
        }
    }
}