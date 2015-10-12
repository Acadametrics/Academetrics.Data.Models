using Academetrics.Data.Enums;
using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(UserRolesValidator))]
  public class UserRolesModel : ModelBase
  {
    public Guid InstitutionId { get; set; }
    public Guid UserId { get; set; }
    public List<Role> Roles { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new UserRolesValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
