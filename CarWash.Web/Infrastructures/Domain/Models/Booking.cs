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
        public Guid? ServiceId { get; set; }

        public Service Service { get; set; }

        public int ItemTotal { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public ServiceType ServiceType { get; set; }

        public VehicleType VehicleType { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Display(Name = "Time")]
        public string Time { get; set; }

        [Display(Name = "Booking Address ")]
        public string BookingAddress { get; set; }

        public Guid? UserId { get; set; }
        public List<User> Users { get; set; }
    }
}
