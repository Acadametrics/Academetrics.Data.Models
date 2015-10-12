using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class RegisterValidator : AbstractValidator<RegisterModel>
  {
    public RegisterValidator()
    {
      RuleFor(x => x.PrimaryTeacher).NotEmpty().WithMessage("Register must have a primary teacher.");
    }
  }
}
