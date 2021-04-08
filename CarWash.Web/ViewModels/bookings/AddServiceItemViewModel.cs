using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class AddServiceItemViewModel
    {
        public Guid? ServiceId { get; set; }

        public Guid? UserId { get; set; }
        
    }
}
