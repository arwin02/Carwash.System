using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.bookings
{
    public class ChangeStatusViewModel
    {
        public Guid? BookingId { get; set; }
        public BookingStatus Status { get; set; }

        public Guid? UserId { get; set; }
    }
}
