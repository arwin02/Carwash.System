using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Enums
{
    public enum BookingStatus
    {

        [Description("Pending")]
        [Display(Name = "Pending")]
        Pending = 1,
        [Description("Confirm")]
        [Display(Name = "Confirm")]
        Confirm = 2,
        [Description("Cancel")]
        [Display(Name = "Cancel")]
        Cancel = 3,
        [Description("Completed")]
        [Display(Name = "Completed")]
        Complete = 4
    }
}
