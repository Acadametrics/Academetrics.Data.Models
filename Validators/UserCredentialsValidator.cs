using Academetrics.Data.Models;
using FluentValidation;
using System;
using System.Collections.Generic;

namespace Academetrics.Data.Validators
{
  public class UserCredentialsValidator : AbstractValidator<UserCredentialsModel>
  {
    public UserCredentialsValidator()
    {
      //RuleFor(x => x.Id).Must(BeValidUserId).WithMessage("User Id cannot be empty."); // todo: find out why this appears to be validated automagically without the need for this line.
      RuleFor(x => x.UserName).NotEmpty().WithMessage("You must have a user name.");
      RuleFor(x => x.Password).NotEmpty().WithMessage("You must set a password.");
    }

    //bool BeValidUserId(Guid userId)
    //{
    //  var emptyGuid = new Guid();

    //  return userId != emptyGuid;
    //}
  }
}
