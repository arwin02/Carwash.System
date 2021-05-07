using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Chat : BaseModel
    {
        public Chat()
        {
            Messages = new List<Message>();
            Users = new List<ChatUser>();
            User = new List<User>();
        }

        public ChatType ChatType { get; set; }

        public string Name { get; set; }

        public List<Message> Messages { get; set; }

        public List<ChatUser> Users { get; set; }

        public List<User> User { get; set; }
    }
}
