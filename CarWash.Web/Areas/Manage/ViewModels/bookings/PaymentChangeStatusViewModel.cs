using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.bookings
{
    public class PaymentChangeStatusViewModel
    {
        public Guid? BookingId { get; set; }
        public PaymentType PaymentType { get; set; }

        public Guid? UserId { get; set; }
    }
}
