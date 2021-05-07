using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;

namespace CarWash.Web.ViewModels.services
{
    public class IndexViewModel
    {
        public Page<Service> Services { get; set; }
    }
}
