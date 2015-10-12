using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class HomeActivityValidator : AbstractValidator<HomeActivityModel>
  {
    public HomeActivityValidator()
    {
      RuleFor(x => x.DueDate).NotEmpty().WithMessage("Homeactivity must have a due date.");
    }
  }
}
