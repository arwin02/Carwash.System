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
        [Display(Name = "Service")]
        public Guid? ServiceId { get; set; }
        [Display(Name = "Costumer")]
        public Guid? CostumerId { get; set; }
        [Display(Name = "Time")]
        public string Time { get; set; }
        [Display(Name = "Vehicle")]
        public string Vehicle { get; set; }
        [Display(Name = "Service Type")]
        public ServiceType ServiceType { get; set; }
        [Display(Name = "Booking Address ")]
        public string BookingAddress { get; set; }

        public Service Services { get; set; }
    }
}
