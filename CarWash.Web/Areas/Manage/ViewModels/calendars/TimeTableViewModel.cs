using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.calendars
{
    public class TimeTableViewModel
    {
        public Guid? BookingId { get; set; }

        public Guid? ServiceId { get; set; }

        public Service Service { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public ServiceType ServiceType { get; set; }

        public VehicleType VehicleType { get; set; }

        public BookingStatus BookingStatus { get; set; }

        public PaymentType PaymentType { get; set; }


        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }

        [Display(Name = "Start Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public string Start { get; set; }

        [Display(Name = "End Time")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:hh:mm tt}")]
        public string End { get; set; }

      

    }
}
