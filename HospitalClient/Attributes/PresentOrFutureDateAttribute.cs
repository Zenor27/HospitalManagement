using System;
using System.ComponentModel.DataAnnotations;

namespace HospitalClient.Models
{
    public sealed class PresentOrFutureDateAttribute : ValidationAttribute
    {
        public string GetErrorMessage() => "Past date not allowed.";

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var errorMessage =  ErrorMessage ?? GetErrorMessage();
            return Convert.ToDateTime(value) >= DateTime.Today ? ValidationResult.Success : new ValidationResult(errorMessage);
        }
    }
}