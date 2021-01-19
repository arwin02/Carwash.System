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

        public Guid? CostumerId { get; set; }
        
        public string Time { get; set; }

        public string Vehicle { get; set; }

        public ServiceType ServiceType { get; set; }

        public string BookingAddress { get; set; }

        public Service Services { get; set; }
    }
}
