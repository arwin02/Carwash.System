using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class ChatUser
    {
        public Guid? UserAdminId { get; set; }

        public Guid? UserId { get; set; }

        public virtual User User { get; set; }

        public Guid? ChatId { get; set; }

        public Chat Chat { get; set; }

        public Role Role { get; set; }

    }
}
