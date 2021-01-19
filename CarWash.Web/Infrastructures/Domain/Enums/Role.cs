using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Enums
{
    public enum Role
    {
        [Display(Name = "Admin")]
        Admin = 0,

        [Display(Name = "ContentAdmin")]
        ContentAdmin = 1,

        [Display(Name = "User")]
        User = 2,


    }
}
