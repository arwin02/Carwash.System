using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Rating : BaseModel
    {
        [Required]
        public Guid? ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
        public bool MaskUser { get; set; }
        public decimal Score { get; set; }
        public bool IsCounted { get; set; }
    }
}
