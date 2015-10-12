using FluentValidation;

namespace Academetrics.Data.Models.Validators
{
  public class LocationValidator : AbstractValidator<LocationModel>
  {
    public LocationValidator()
    {
      RuleFor(x => x.LocationCode).NotEmpty().WithMessage("Location must have a location code.");
    }
  }
}
