using Academetrics.Data.Models;
using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class UserClaimsValidator : AbstractValidator<UserClaimsModel>
  {
    public UserClaimsValidator()
    {
      RuleFor(x => x.InstitutionId).NotEmpty().WithMessage("User claims must have an institution.");
    }
  }
}
