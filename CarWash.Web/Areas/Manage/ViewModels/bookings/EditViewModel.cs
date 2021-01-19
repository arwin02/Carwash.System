using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.bookings
{
    public class EditViewModel
    {
        public Guid? Id { get; set; }

        public string Time { get; set; }

        public string Vehicle { get; set; }

        public ServiceType ServiceType { get; set; }

        public string BookingAddress { get; set; }


        public decimal Price { get; set; }
    }
}
