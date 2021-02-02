using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Enums
{
    public enum PriceList
    {
        [Description(" 260")]
        firstPrice = 260,
        [Description(" 450")]
        secondPrice = 450,
        [Description(" 1000")]
        thirdPrice = 1000,
        [Description(" 3000")]
        fourthPrice = 3000,

    }
}
