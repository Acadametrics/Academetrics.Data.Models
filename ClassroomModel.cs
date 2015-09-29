using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Academetrics.Data.Models
{
  public class ClassroomModel : ModelBase
  {
    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      throw new NotImplementedException();
    }
  }
}
