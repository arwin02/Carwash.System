using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Controllers
{
    public class SignalHub : Hub
    {
        private readonly DefaultDbContext _context;

        public SignalHub(DefaultDbContext context)
        {
            _context = context;
        }

        public override async Task OnConnectedAsync()
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetPublicUserId);
            var userAdmin = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetAdminUserId);
            var users = (user != null ? user : userAdmin);

            await Clients.All.SendAsync("SendAction", users.UserName, "joined");
        }

        public override async Task OnDisconnectedAsync(Exception ex)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetPublicUserId);
            var userAdmin = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetAdminUserId);
            var users = (user != null ? user : userAdmin);

            await Clients.All.SendAsync("SendAction", users.UserName, "left");
        }

        public async Task Send(string text, Guid? userid, Guid? chatid, string username)
        {

            var message = new Message()
            {
                Id = Guid.NewGuid(),
                Text = text,
                ChatId = chatid,
                UserId = userid,
                Name = username,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Timestamp = DateTime.UtcNow,
            };

            this._context.Messages.Add(message);
            await _context.SaveChangesAsync();

            await Clients.All.SendAsync("SendMessage", text, message.Timestamp.ToString("hh:mm tt"), message.Timestamp.ToString("MMMM dd"), userid);

        }



        public async Task SendMessage(Guid? userId, string message)
        {
            await Clients.All.SendAsync("ReceiveNotification", userId, message);
        }
    }
}
