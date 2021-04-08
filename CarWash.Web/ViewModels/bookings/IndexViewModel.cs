using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class IndexViewModel
    {
        public Guid? UserId { get; set; }

        public List<Booking> Bookings { get; set; }

        public List<Service> Services { get; set; }
    }
}
