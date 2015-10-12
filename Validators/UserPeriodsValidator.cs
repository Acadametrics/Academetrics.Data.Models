using Academetrics.Data.Models;
using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class UserPeriodsValidator : AbstractValidator<UserPeriodsModel>
  {
    public UserPeriodsValidator()
    {
      RuleFor(x => x.InstitutionId).NotEmpty().WithMessage("User Periods must be assigned to an institution.");
      RuleFor(x => x.UserId).NotEmpty().WithMessage("User Periods must be assigned to a user.");
    }
  }
}
