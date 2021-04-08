using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class PhaseOneViewModel
    {
        [Required(ErrorMessage = "VehicleType is required")]
        public Guid? UserId { get; set; }

        [Required(ErrorMessage = "VehicleType is required")]
        public VehicleType VehicleType { get; set; }
    }
}
