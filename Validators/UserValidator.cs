using Academetrics.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Academetrics.Data.Models.Validators
{
  public class UserValidator : AbstractValidator<UserModel>
  {
    public UserValidator()
    {
      //RuleFor(x => x.Id).Must(BeValidUserId).WithMessage("User Id cannot be empty."); // todo: find out why this appears to be validated automagicaly without the need for this line.
      RuleFor(x => x.Email).EmailAddress().WithMessage("You must supply an email address.");
      RuleFor(x => x.Institutions).Must(HaveAtLeastOneInstitution).WithMessage("User must be assigned to at least one institution.");

    }

    //bool BeValidUserId(Guid userId)
    //{
    //  var emptyGuid = new Guid();

    //  return userId != emptyGuid;
    //} 

    bool HaveAtLeastOneInstitution(IList<Guid> institutions)
    {
      return institutions.Count > 0;
    }
  }
}
