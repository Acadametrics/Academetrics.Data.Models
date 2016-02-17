using Academetrics.Data.Objects.Interfaces;
using Academetrics.Data.Models;
using FluentValidation;
using System.Linq;

namespace Academetrics.Data.Models.Validators
{
  public class PeriodValidator : AbstractValidator<PeriodModel>
  {
    public PeriodValidator()
    {
      //RuleFor(x => x.InstitutionId).NotEmpty().WithMessage("Period must be assigned to an institution.");
      RuleFor(x => x.Start).NotEmpty().WithMessage("Period must have a start date and time.");
      RuleFor(x => x.End).NotEmpty().WithMessage("Period must have an end date and time.");
      RuleFor(x => x.Classroom).Must(HaveLocationsAndSetCodes).WithMessage("Period classroom needs to have both location(s) and setcode(s).");
    }

    bool HaveLocationsAndSetCodes(ClassroomModel classroom)
    {
      if (classroom.Locations == null || !classroom.Locations.Any())
      {
        return false;
      }

      if (classroom.SetCodes == null || !classroom.SetCodes.Any())
      {
        return false;
      }

      return true;
    }
  }
}
