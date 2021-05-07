using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.ViewModels.chats;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace CarWash.Web.Controllers
{
    public class ChatsController : Controller
    {
        private readonly IHubContext<SignalHub> _hubContext;
        private readonly DefaultDbContext _context;

        public ChatsController(DefaultDbContext context, IHubContext<SignalHub> hubContext)
        {
            _context = context;
            _hubContext = hubContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet, Route("chats/private-chat/{chatId}")]
        public IActionResult Chat(Guid? chatId)
        {
            var chat = this._context.Chats
                                    .Include(c => c.Messages)
                                    .OrderByDescending(c => c.Messages.OrderByDescending(m => m.Timestamp))
                                    .FirstOrDefault(c => c.Id == chatId);
            if (chat == null)
            {
                return BadRequest();
            }
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetPublicUserId);
            var userAdmin = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetAdminUserId);


            var users = (user != null ? user : userAdmin);
            return View(new ChatViewModel
            {
                User = users,
                Chat = chat,
            });
        }

        [HttpGet, Route("chats/find-admin")]
        public IActionResult Find()
        {
            var userRole = this._context.UserRoles.FirstOrDefault(x => x.UserId != WebID.GetPublicUserId && x.Role == Infrastructures.Domain.Enums.Role.Admin);

            var users = this._context.Users.Where(x => x.Id == userRole.UserId)
                .ToList();


            return View(new FindViewModel
            {
                Users = users
            });
        }

        [HttpGet, Route("/chats/messages")]
        public IActionResult Messages()
        {
            var chats = this._context.Chats
                                     .Include(x => x.Users)
                                            .ThenInclude(x => x.User)
                                     .Where(x => x.ChatType == Infrastructures.Domain.Enums.ChatType.Private && x.Users.Exists(u => u.UserId == WebID.GetPublicUserId)
                                     ).ToList();


            return View(new MessagesViewModel
            {
                Chats = chats

            });
        }

        [HttpGet, Route("/chats/create-private-room/{userAdminId}")]
        public async Task<IActionResult> CreatePrivateRoom(Guid? userAdminId)
        {
            var user = this._context.Users.FirstOrDefault(x => x.Id == userAdminId);

            var userPublic = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetPublicUserId);
            var userAdmin = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetAdminUserId);


            var chat = new Chat
            {
                Id = Guid.NewGuid(),
                ChatType = Infrastructures.Domain.Enums.ChatType.Private,
         };

            chat.Users.Add(new ChatUser
            {
                UserAdminId = userAdminId,
                UserId = WebID.GetPublicUserId
            });

            this._context.Chats.Add(chat);
            await _context.SaveChangesAsync();

            return RedirectToAction("Chat", new { ChatId = chat.Id });
        }

    }
}