﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Areas.Manage.ViewModels.userroles;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarWash.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    [AllowAnonymous]
    public class UserRolesController : Controller
    {
        private readonly DefaultDbContext _context;

        public UserRolesController(DefaultDbContext context)
        {
            _context = context;
        }

  
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/user-roles/{userId}")]
        [HttpGet, Route("manage/user-roles/index/{userId}")]
        public IActionResult Index(Guid? userId, int pageSize = 5, int pageIndex = 1, string keyword = "")
        {
            Page<Role> result = new Page<Role>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            var roles = this._context.UserRoles.Where(r => r.UserId == userId).Select(r => r.Role).ToList();

            if (string.IsNullOrEmpty(keyword) == false)
            {
                roles = roles.Where(r => r.ToString().Contains(keyword)).ToList();
            }

            long queryCount = roles.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));

            result.Items = roles.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;


            User user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            return View(new IndexViewModel()
            {
                UserId = userId,
                UserName = (user != null ? user.UserName : ""),
                Roles = result
            });
        }

        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpPost, Route("manage/user-roles/add-role-to-user")]
        public IActionResult Add(RemoveAddUserRoleViewModel model)
        {
            Enum.TryParse(model.Role, out Role role);
            var duplicate = this._context.UserRoles.FirstOrDefault(ur => ur.UserId == model.UserId && ur.Role == role);

            if (duplicate == null)
            {
                this._context.UserRoles.Add(new UserRole()
                {
                    Id = Guid.NewGuid(),
                    UserId = model.UserId.Value,
                    Role = role
                });

                this._context.SaveChanges();
            }

            var redirect = "/manage/user-roles/" + model.UserId;

            return RedirectPermanent(redirect);
        }

        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpPost, Route("manage/user-roles/remove-role-from-user")]
        public IActionResult Remove(RemoveAddUserRoleViewModel model)
        {
            Enum.TryParse(model.Role, out Role role);
            var userRole = this._context.UserRoles.FirstOrDefault(ur => ur.UserId == model.UserId && ur.Role == role);

            if (userRole != null)
            {
                this._context.UserRoles.Remove(userRole);

                this._context.SaveChanges();
            }

            var redirect = "/manage/user-roles/" + model.UserId;

            return RedirectPermanent(redirect);
        }
    }
}