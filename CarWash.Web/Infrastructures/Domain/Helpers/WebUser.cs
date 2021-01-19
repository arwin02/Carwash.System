﻿using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Helpers
{
    public static class WebUser
    {
        static IServiceProvider services = null;

        public static bool IsAuthenticated
        {
            get => Current.User.Identity.IsAuthenticated && UserId.HasValue;
        }

        public static void SetUser(User user, List<Role> roles, List<Group> groups)
        {
            EmailAddress = user.EmailAddress;
            FirstName = user.FirstName;
            LastName = user.LastName;
            UserId = user.Id.Value;
            Gender = user.Gender;
            PhoneNumber = user.PhoneNumber;
            Roles = roles;
            Groups = groups;




        }

        public static IServiceProvider Services
        {
            get { return services; }
            set
            {
                if (services != null)
                {
                    throw new Exception("Can't set once a value has already been set.");
                }
                services = value;
            }
        }

        public static HttpContext Current
        {
            get
            {
                IHttpContextAccessor httpContextAccessor = services.GetService(typeof(IHttpContextAccessor)) as IHttpContextAccessor;
                return httpContextAccessor?.HttpContext;
            }
        }

        public static string SessionCode
        {
            get => Current.Session.GetString("SessionCode");
            set => Current.Session.SetString("SessionCode", value);
        }

        public static Guid? UserId
        {
            get => Current.Session.GetObjectFromJson<Guid?>("UserId");
            set => Current.Session.SetObjectAsJson("UserId", value);
        }

        public static List<Group> Groups
        {
            get => Current.Session.GetObjectFromJson<List<Group>>("Groups");
            set => Current.Session.SetObjectAsJson("Groups", value);
        }

        public static string FirstName
        {
            get => Current.Session.GetString("FirstName");
            set => Current.Session.SetString("FirstName", value);
        }

        public static string LastName
        {
            get => Current.Session.GetString("LastName");
            set => Current.Session.SetString("LastName", value);
        }

        public static string EmailAddress
        {
            get => Current.Session.GetString("EmailAddress");
            set => Current.Session.SetString("EmailAddress", value);
        }

        public static Gender Gender
        {
            get => Current.Session.GetObjectFromJson<Gender>("Gender");
            set => Current.Session.SetObjectAsJson("Gender", value);
        }

        public static string PhoneNumber
        {
            get => Current.Session.GetString("PhoneNumber");
            set => Current.Session.SetString("PhoneNumber", value);
        }

        public static List<Role> Roles
        {
            get => Current.Session.GetObjectFromJson<List<Role>>("Roles");
            set => Current.Session.SetObjectAsJson("Roles", value);
        }



        public static string UserName
        {
            get => string.Format("{0} {1}", FirstName, LastName);
        }

        public static bool IsInRole(Role role)
        {
            if (WebUser.Roles == null)
            {
                return false;
            }

            return WebUser.Roles.Contains(role);
        }


    }
}
