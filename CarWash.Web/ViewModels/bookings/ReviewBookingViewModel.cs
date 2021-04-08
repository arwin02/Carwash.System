using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class ReviewBookingViewModel
    {
        public Booking Booking { get; set; }
        public List<Booking> Bookings { get; set; }

        public decimal TotalPrice => Bookings.Sum(b => b.Price);
        
    }
}
