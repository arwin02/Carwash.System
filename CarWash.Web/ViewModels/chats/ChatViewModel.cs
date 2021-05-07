using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.chats
{
    public class ChatViewModel
    {
        public User User { get; set; }

        public Chat Chat { get; set; }

    }
}
