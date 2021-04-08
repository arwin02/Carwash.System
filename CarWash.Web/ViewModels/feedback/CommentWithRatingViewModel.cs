using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.ViewModels.feedback
{
    public class CommentWithRatingViewModel
    {
        public Guid? ServiceId { get; set; }

        public Guid? UserId { get; set; }

        public string Comment { get; set; }

        public decimal Score { get; set; }
    }
}

