using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Areas.Manage.ViewModels.services
{
    public class ThumbnailViewModel
    {
        public Guid? ServiceId { get; set; }

        public IFormFile Thumbnail { get; set; }
    }
}
