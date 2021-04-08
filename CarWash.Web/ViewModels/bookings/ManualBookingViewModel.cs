using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class ManualBookingViewModel
    {

        public Guid? UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string BookingAddress { get; set; }
        public DateTime Time { get; set; }
    }
}
