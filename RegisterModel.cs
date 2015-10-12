using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(RegisterValidator))]
  public class RegisterModel : ModelBase
  {
    // Attendees
    public Guid? PrimaryTeacher { get; set; }
    public IList<Guid> Teachers { get; set; }
    public IList<Guid> Students { get; set; }
    public IList<Guid> AdditionalStudents { get; set; } // i.e. ones that aren't assigned by setcode
    public IList<Guid> SupportWorkers { get; set; }

    // Absentees
    public IList<Guid> AbsentTeachers { get; set; }
    public IList<Guid> AbsentStudents { get; set; }
    public IList<Guid> AbsentSupportWorkers { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new RegisterValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
