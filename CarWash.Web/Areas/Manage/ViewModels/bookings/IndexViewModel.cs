using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.bookings
{
    public class IndexViewModel
    {
        public Page<Booking> Bookings { get; set; }

        //public Booking booking { get; set; }

        public ServiceType ServiceT { get; set; }

        public List<ServiceType> Serviceses
        {
            get
            {
                return Enum.GetValues(typeof(ServiceType)).Cast<ServiceType>().ToList();
            }
        }
    }
}