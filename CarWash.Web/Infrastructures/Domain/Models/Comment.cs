using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Comment : BaseModel
    {
        [Required]
        public Guid? ServiceId { get; set; }
        public Service Service { get; set; }
        public Guid? UserId { get; set; }
        public User User { get; set; }
        public bool MaskUser { get; set; }
        [MaxLength(100)]
        public string UserName { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }
        public bool IsPublished { get; set; }
        public int Likes { get; set; }
        public bool LikesEnabled { get; set; }
    }
}