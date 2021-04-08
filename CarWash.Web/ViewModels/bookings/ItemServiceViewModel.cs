using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class ItemServiceViewModel
    {
        public Guid? ServiceId { get; set; }


        public int ItemTotal { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }
        
        public DateTime UpdateAt { get; set; }

        public string Description { get; set; }

        public ServiceType ServiceType { get; set; }

    }
}
