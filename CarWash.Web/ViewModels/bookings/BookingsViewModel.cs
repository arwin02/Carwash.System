﻿using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Models;
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
        public Guid? CostumerId { get; set; }

        [Display(Name = "Vehicle")]
        public string Vehicle { get; set; }

        [Display(Name = "Service Type")]
        public ServiceType ServiceType { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }


        [Display(Name = "Time")]
        public string Time { get; set; }

        [Display(Name = "Booking Address")]
        public string BookingAddress { get; set; }

    }
}

