using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.userroles
{
    public class IndexViewModel
    {
        public Guid? UserId { get; set; }

        public string UserName { get; set; }

        public Page<Role> Roles { get; set; }

        public Role Roleles { get; set; }

        public List<Role> roleles
        {
            get
            {
                return Enum.GetValues(typeof(Role)).Cast<Role>().ToList();
            }
        }
    }
}