using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.userroles
{
    public class RemoveAddUserRoleViewModel
    {
        public Guid? UserId { get; set; }

        public string Role { get; set; }
    }
}