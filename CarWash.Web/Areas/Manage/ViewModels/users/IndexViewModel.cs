using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.users
{
    public class IndexViewModel
    {
        public Page<User> Users { get; set; }

        public LoginStatus Status { get; set; }

        public List<LoginStatus> Statuses
        {
            get
            {
                return Enum.GetValues(typeof(LoginStatus)).Cast<LoginStatus>().ToList();
            }
        }
    }
}