using Academetrics.Data.Enums;
using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(UserPeriodsValidator))]
  public class UserPeriodsModel : ModelBase
  {
    SortedDictionary<long, string> _Periods;

    public Guid InstitutionId { get; set; }
    public Role Role { get; set; }
    public Guid UserId { get; set; }
    public SortedDictionary<long, string> Periods
    {
      get { return _Periods; }
      set { _Periods = value; }
    }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new UserPeriodsValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
