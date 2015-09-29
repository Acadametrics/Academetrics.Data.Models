using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Academetrics.Data.Enums;

namespace Academetrics.Data.Models
{
  public interface IUserClaimsModel : IModelBase
  {
    List<ClaimType> Claims { get; set; }
    Guid InstitutionId { get; set; }
  }
}