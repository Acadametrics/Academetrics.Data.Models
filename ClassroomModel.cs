﻿using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(ClassroomValidator))]
  public class ClassroomModel : ModelBase
  {
    //public InstitutionModel Institution { get; set; } // todo: is this really necessary?
    public List<SubjectModel> Subjects { get; set; }  // for split periods
    public List<SetCodeModel> SetCodes { get; set; }  // for joint-classes
    public List<LocationModel> Locations { get; set; }	// for mobile classes

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new ClassroomValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
