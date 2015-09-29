using Academetrics.Data.Models;
using FluentValidation;

namespace Academetrics.Data.Validators
{
  public class InstitutionValidator : AbstractValidator<InstitutionModel>
  {
    public InstitutionValidator()
    {
      RuleFor(x => x.Type).NotEmpty().WithMessage("Institution must have a type.");
      RuleFor(x => x.TownCity).NotEmpty().WithMessage("Institution must have a Town/City.");
      RuleFor(x => x.Name).NotEmpty().WithMessage("Institution must have a name.");
    }
  }
}
