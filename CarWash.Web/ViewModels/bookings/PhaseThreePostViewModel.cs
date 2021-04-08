using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class PhaseThreePostViewModel
    {
        [Required(ErrorMessage = "UserId is required")]
        public Guid? UserId { get; set; }

        public Guid? ServiceId { get; set; }


        [Required(ErrorMessage = "UserName is required")]
        public string UserName { get; set; }


        [Required(ErrorMessage = "PhoneNumber is required")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Time is required")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }

    }
}
