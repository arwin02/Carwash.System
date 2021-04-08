using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class ServiceIndivListViewModel : Service
    {
        public List<Service> Services { get; set; }
    }
}
