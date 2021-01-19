using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.userGroup
{
    public class UsersIndexViewModel
    {
        public Guid? GroupId { get; set; }

        public string GroupName { get; set; }

        public Page<User> Users { get; set; }
    }
}
