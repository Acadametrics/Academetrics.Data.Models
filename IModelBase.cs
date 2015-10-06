using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Academetrics.Data.Models
{
  public interface IModelBase
  {
    string AssigneeId { get; set; }
    string ETag { get; set; }
    string Id { get; set; }
    string Timestamp { get; set; }

    IEnumerable<ValidationResult> Validate(ValidationContext validationContext);
  }
}