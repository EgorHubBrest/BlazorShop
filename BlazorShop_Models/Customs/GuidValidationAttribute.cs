using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShop_Models.Customs
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class GuidValidationAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is Guid)
            {
                Guid guidValue = (Guid)value;

                if (guidValue != Guid.Empty)
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("Please enter a valid GUID.");
        }
    }
}
