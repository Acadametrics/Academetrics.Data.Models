using Academetrics.Data.Enums;
using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(UserValidator))]
  public class UserModel : ModelBase
  {
    public string Code; // this is here for teacher/student/etc. reference, but ID should be used in all lookup cases.
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Salutation { get; set; }
    public string Initials { get; set; }
    public int Age { get; set; }
    public int DayOfBirth { get; set; }
    public int MonthOfBirth { get; set; }
    public int YearOfBirth { get; set; }
    public string Email { get; set; }
    public Gender Gender { get; set; }
    public int DateOfBirth { get; set; }
    public IList<Guid> Institutions { get; set; }
    public IList<Guid> Children { get; set; }
    public IList<Guid> Parents { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new UserValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
