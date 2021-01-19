using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Service : BaseModel
    {
        [Display(Name = "Descriptions")]
        [StringLength(520)]
        public string Description { get; set; }

        [Display(Name = "Service Type")]
        [StringLength(255)]
        public ServiceType ServiceType { get; set; }

        [Display(Name = "Vehicle")]
        public string Vehicle { get; set; }

        [RegularExpression(@"^\d+\.\d{0,2}$")]
        [Range(0, 9999999999999999.99)]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

    }
}
