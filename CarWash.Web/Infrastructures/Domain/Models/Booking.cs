using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Booking : BaseModel
    {
        [Display(Name = "Services")]
        public Guid? ServiceId { get; set; }

        public Service Services { get; set; }

        [Display(Name = "Costumer")]
        public Guid? CostumerId { get; set; }

        [Display(Name = "Time")]
        public string Time { get; set; }

        [Display(Name = "Booking Address ")]
        public string BookingAddress { get; set; }


        public ServiceType ServiceType { get; set; }

        public string Vehicle { get; set; }
    }
}
