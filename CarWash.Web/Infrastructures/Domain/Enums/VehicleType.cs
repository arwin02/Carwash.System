using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Enums
{
    public enum VehicleType
    {
        [Description("Small")]
        Small =1 ,
        [Description("Medium")]
        Medium =2,
        [Description("Large")]
        Large =3,
        [Description(" Extra Large")]
        Extra_Large =4,

    }
}
