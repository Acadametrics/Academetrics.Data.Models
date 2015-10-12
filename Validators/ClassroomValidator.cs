using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class ClassroomValidator : AbstractValidator<ClassroomModel>
  {
    public ClassroomValidator()
    {
      RuleFor(x => x.Locations).NotEmpty().WithMessage("Classroom must have a location.");
    }
  }
}
