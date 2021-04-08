using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.ViewModels.service;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class BookingsViewModel
    {
        
        public Guid? UserId { get; set; }

        public string UserName { get; set; }

        public string PhoneNumber { get; set; }

        public string  Email { get; set; }

        public Guid? ServiceId { get; set; }

        public decimal Price { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ServiceType ServiceType { get; set; }

        [Display(Name = "Time")]
        public string Time { get; set; }


        public string BookingAddress { get; set; }


    }
}

