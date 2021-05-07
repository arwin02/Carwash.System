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
        
        public User User { get; set; }

        public Service Service { get; set; }

        
        public string Time { get; set; }

        public string BookingAddress { get; set; }


    }
}

