using System;
using System.ComponentModel.DataAnnotations;

namespace MovieBox.Models
{
    public class Min18Years : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
<<<<<<< HEAD
            var customer = (Customer)validationContext.ObjectInstance;
=======
            var customer = (Customer) validationContext.ObjectInstance;
>>>>>>> 9571c89b8f2096dfc4c400bc6edff1b4871fe012

            if (customer.MembershipTypeId == MembershipType.Unknown ||
                customer.MembershipTypeId == MembershipType.PayAsYouGo)
                return ValidationResult.Success;

            if (customer.BirthDate == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Customer should be at least 18 years old to go on a membership.");
        }
    }
}