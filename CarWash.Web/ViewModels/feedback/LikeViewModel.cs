using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.feedback
{
    public class LikeViewModel
    {
        public Guid? UserId { get; set; }
        public Guid? ServiceId { get; set; }
        public bool IsLiked { get; set; }
    }
}

