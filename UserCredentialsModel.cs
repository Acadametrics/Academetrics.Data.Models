using Academetrics.Data.Validators;
using FluentValidation.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(UserCredentialsValidator))]
  public class UserCredentialsModel : ModelBase
  {
    //public string UserName { get; set; }
    public string Password { get; set; }
    // todo: the model should never contain the salt!  It stays behind the service layer.
    //public string UserId { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new UserCredentialsValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
