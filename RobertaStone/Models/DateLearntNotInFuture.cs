using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RobertaStone.Models
{
    public class DateLearntNotInFuture : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var lexis = (Lexis)validationContext.ObjectInstance;

            if (lexis.DateLearnt == DateTime.MinValue)
                return new ValidationResult("Please enter a valid date (DD-MM-YYYY)");

            return (lexis.DateLearnt > DateTime.UtcNow)
                ? new ValidationResult("You cannot enter a date in the future.")
                : ValidationResult.Success;
        }
    }
}