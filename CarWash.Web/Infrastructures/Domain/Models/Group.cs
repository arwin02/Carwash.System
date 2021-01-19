using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Group : BaseModel
    {
        [StringLength(255)]
        public string Name { get; set; }

        public string Description { get; set; }

        public Status Status { get; set; }
    }
}
