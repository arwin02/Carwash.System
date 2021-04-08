using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class PhaseTwoViewModel
    {
        public Guid? UserId { get; set; }

        public Guid? BookingId { get; set; }

        public ServiceType ServiceType { get; set; }

        public List<Booking> Bookings { get; set; }
    }
}
