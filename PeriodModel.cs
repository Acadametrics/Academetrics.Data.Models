using Academetrics.Data.Enums;
using Academetrics.Data.Models.Validators;
using FluentValidation.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace Academetrics.Data.Models
{
  [Validator(typeof(PeriodValidator))]
  public class PeriodModel : ModelBase
  {
    public Guid InstitutionId { get; set; }
    public string PeriodCode { get; set; }
    public PeriodType PeriodType { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string KeyDetails { get; set; }
    public IList<HomeActivityModel> Homework { get; set; }
    public ClassroomModel Classroom { get; set; }
    public RegisterModel Register { get; set; }

    public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
      var validator = new PeriodValidator();
      var result = validator.Validate(this);
      return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
    }
  }

  //[Validator(typeof(PeriodValidator))]
  //public class PeriodModel : ModelBase
  //{
  //  public Guid InstitutionId { get; set; }
  //  public string PeriodCode { get; set; }
  //  public PeriodType PeriodType { get; set; }
  //  public DateTime Start { get; set; }
  //  public DateTime End { get; set; }
  //  public string Name { get; set; }
  //  public string Description { get; set; }
  //  public string KeyDetails { get; set; }
  //  public IList<IHomeActivity> Homework { get; set; }
  //  public IClassroom Classroom { get; set; }
  //  public IRegister Register { get; set; }

  //  public override IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
  //  {
  //    var validator = new PeriodValidator();
  //    var result = validator.Validate(this);
  //    return result.Errors.Select(item => new ValidationResult(item.ErrorMessage, new[] { item.PropertyName }));
  //  }
  //}
}
