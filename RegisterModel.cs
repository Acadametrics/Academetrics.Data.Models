using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Academetrics.Data.Models
{
  public class RegisterModel : ModelBase
  {
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      throw new NotImplementedException();
    }
  }
}
