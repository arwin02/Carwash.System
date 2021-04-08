using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.payment
{
    public class PaymentGatewayViewModel
    {
        public Guid? UserId { get; set; }

        public IFormFile PaymentImage { get; set; }
    }
}
