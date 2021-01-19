using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Enums
{
    public enum LoginStatus
    {
        [Display(Name = "Active")]
        Active = 1,

        [Display(Name = "Inactive")]
        InActive = 2,

        [Display(Name = "NeedToChangePassword")]
        NeedToChangePassword = 3,

        [Display(Name = "Unverified")]
        Unverified = 4,

        [Display(Name = "Locked")]
        Locked = 5
    }
}
