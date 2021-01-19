using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Enums
{
    public enum ServiceType
    {


        [Display(Name = "Wash")]
        Wash = 1,

        [Display(Name = "Waterless")]
        Waterless = 2,

        [Display(Name = "Shine")]
        Shine = 3,

        [Display(Name = "Signature")]
        Signature = 4,


    }
}
