using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(SubjectValidator))]
  public class SubjectModel : ModelBase
  {
    public string SubjectCode { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new SubjectValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
