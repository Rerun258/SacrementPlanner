using System;
using System.ComponentModel.DataAnnotations;

namespace SacrementPlanner.ValidationAttributes
{
    public class SundayOnlyAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime date)
            {
                if (date.DayOfWeek == DayOfWeek.Sunday)
                {
                    return ValidationResult.Success;
                }
                else
                {
                    return new ValidationResult("Meeting Date must be a Sunday.");
                }
            }

            return new ValidationResult("Invalid date format.");
        }
    }
}