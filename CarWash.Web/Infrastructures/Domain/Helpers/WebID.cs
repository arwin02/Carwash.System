using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Helpers
{
    public static class WebID
    {
        public static Guid? GetAdminUserId { get; set; }

        public static Guid? GetPublicUserId { get; set; }

        public static Guid? GetServiceId { get; set; }

        public static Guid? GetBookingId { get; set; }

        public static void SetBookingId(Guid? Id)
        {
            GetBookingId = Id;

        }

        public static void SetServiceId(Guid? Id)
        {
            GetServiceId = Id;
        }

        public static void SetUserId(Guid? Id)
        {
            GetPublicUserId = Id;
        }

        public static void SetAdminId(Guid? Id)
        {
            GetAdminUserId = Id;
        }
    }
}
