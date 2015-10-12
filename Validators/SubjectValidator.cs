using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class SubjectValidator : AbstractValidator<SubjectModel>
  {
    public SubjectValidator()
    {
      RuleFor(x => x.SubjectCode).NotEmpty().WithMessage("Subject must have a subject code.");
    }
  }
}
