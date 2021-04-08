using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.home
{
    public class IndexViewModel
    {
        public List<Service> Services { get; set; }
    }
}
