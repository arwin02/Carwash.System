using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarWash.Web.Infrastructures.Domain.Models
{
    public class Contact : BaseModel
    {
        public string Name { get; set; }

        public string EmailAddress { get; set; }

        public string Subject { get; set; }

        public string Message { get; set; }
    }
}
