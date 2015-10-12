using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class SetCodeValidator : AbstractValidator<SetCodeModel>
  {
    public SetCodeValidator()
    {
      RuleFor(x => x.ClassCode).NotEmpty().WithMessage("SetCodes need a class code.");
      RuleFor(x => x.SubjectCode).NotEmpty().WithMessage("SetCodes need a subject code.");
    }
  }
}