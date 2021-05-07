using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.bookings
{
    public class PhaseThreePostViewModel
    {
      
        public Guid? UserId { get; set; }

        
        public Guid? BookingId { get; set; }

        [Required(ErrorMessage = "Phone Number is required")]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Time is required")]
        [Display(Name = "Time")]
        public string Time { get; set; }

        [Required(ErrorMessage = "Address is required")]
        [Display(Name = "Address Number")]
        public string Address { get; set; }

    }
}
