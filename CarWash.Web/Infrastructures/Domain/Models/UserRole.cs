using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class UserRole : BaseModel
    {
        public Guid UserId { get; set; }

        public Role Role { get; set; }
    }
}
