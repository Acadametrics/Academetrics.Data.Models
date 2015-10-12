using Academetrics.Data.Models;
using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class UserRolesValidator : AbstractValidator<UserRolesModel>
  {
    public UserRolesValidator()
    {
      RuleFor(x => x.InstitutionId).NotEmpty().WithMessage("User roles must have an institution.");
    }
  }
}
