using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(LocationValidator))]
  public class LocationModel : ModelBase
  {
    public string LocationCode { get; set; }
    public string Name { get; set; }
    public string Building { get; set; }
    public string Floor { get; set; }
    public string Room { get; set; }
    public string Description { get; set; }
    public decimal Latitude { get; set; }
    public decimal Longtitude { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new LocationValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }
}