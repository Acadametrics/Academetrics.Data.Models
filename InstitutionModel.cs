using Academetrics.Data.Enums;
using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(InstitutionValidator))]
  public class InstitutionModel : ModelBase
  {
    public InstitutionType Type { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string LogoUrl { get; set; }
    public string Url { get; set; }
    public string TownCity { get; set; }
    public string County { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string[] SetCodes { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new InstitutionValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}
