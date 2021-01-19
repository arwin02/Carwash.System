using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.account
{
    public class ThumbnailViewModel
    {
        public Guid? UserId { get; set; }

        public IFormFile Thumbnail { get; set; }
    }
}
