using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.services
{
    public class EditServiceViewModel
    {
        public Guid? Id { get; set; }

        public string Description { get; set; }

        public ServiceType ServiceType { get; set; }

        public string Vehicle { get; set; }

        public decimal Price { get; set; }
    }
}


