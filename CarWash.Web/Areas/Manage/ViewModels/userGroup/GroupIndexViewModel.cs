using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.userGroup
{
    public class GroupIndexViewModel
    {
        public Guid? UserId { get; set; }

        public string UserName { get; set; }

        public Page<Group> Groups { get; set; }


    }
}