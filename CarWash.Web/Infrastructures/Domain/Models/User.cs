using CarWash.Web.Infrastructures.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class User : BaseModel
    {
        public User()
        {
            this.LoginStatus = LoginStatus.InActive;
            this.UserName = FirstName + LastName;
        }


        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }

        public LoginStatus LoginStatus { get; set; }

        public int LoginRetries { get; set; }

        public Gender Gender { get; set; }

        
        public string PhoneNumber { get; set; }

        public bool MaskUser { get; set; }

        public string RegistrationCode { get; set; }

        //public Guid? BookingId { get; set; }

        public Booking Bookings { get; set; }
    }
}