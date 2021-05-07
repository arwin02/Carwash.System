using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.home
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "An Email Address is required")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "An Name  is required")]
        [StringLength(160)]
        public string Name { get; set; }

        [Required(ErrorMessage = "An Subject  is required")]
        [StringLength(200)]
        public string Subject { get; set; }

        [Required(ErrorMessage = "An Message  is required")]
        [StringLength(500)]
        public string Message { get; set; }
    }
}
