using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "First-name is required to register")]
        public string FirstName { get; set; }


        [Required(ErrorMessage = "Last-name is required to register")]
        public string LastName { get; set; }



        [Required(ErrorMessage = "Password is required to register")]
        public string Password { get; set; }



        [Required(ErrorMessage = "Confirm-password is required to register")]
        public string ConfirmPassword { get; set; }


        [Required(ErrorMessage = "Please type -in a valid email address")]
        public string EmailAddress { get; set; }


        [Required(ErrorMessage = "Phone Number is required to register")]
        public string PhoneNumber { get; set; }

    }
}
