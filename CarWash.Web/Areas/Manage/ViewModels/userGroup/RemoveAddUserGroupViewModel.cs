using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.userGroup
{
    public class RemoveAddUserGroupViewModel
    {
        public Guid? UserId { get; set; }

        public Guid? GroupId { get; set; }

        public string Redirect { get; set; }
    }
}
