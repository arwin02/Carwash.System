﻿using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.users
{
    public class CreateViewModel
    {
        [Required]
        public string EmailAddress { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [Required]
        public Role Role { get; set; }
    }
}