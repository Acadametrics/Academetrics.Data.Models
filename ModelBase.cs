using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Academetrics.Data.Models
{
  public abstract class ModelBase : IValidatableObject, IModelBase
  {
    public string AssigneeId { get; set; }
    public string Id { get; set; }
    public string ETag { get; set; }
    public string Timestamp { get; set; }

    public abstract IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
  }
}
