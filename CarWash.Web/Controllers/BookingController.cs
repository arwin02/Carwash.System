using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.ViewModels.bookings;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CarWash.Web.Controllers
{
    public class BookingController : Controller
    {

        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;


        public BookingController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;

          
            
        }


        [HttpGet,Route("/booking/index")]
        public IActionResult Index()
        {
            //retrieving data in database including services data with eager loading.
                  
            
            var bookings = this._context.Bookings.Include(b => b.Services);

            return View(new IndexViewModel
            {

                Bookings = bookings.ToList()
            });
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/booking/costumer/{userId}")]
        public IActionResult Bookings(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            if(user == null)
            {
                return BadRequest();
            }
            ViewBag.CostumerId = user.Id.Value;
            return View();
        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/booking/costumer")]
        public IActionResult Bookings(BookingsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var booking = new Booking()
                {
                    Id = Guid.NewGuid(),
                    CostumerId = model.CostumerId,
                    BookingAddress = model.BookingAddress,
                    ServiceType = model.ServiceType,
                    Time = model.Time,
                    Vehicle = model.Vehicle,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,

                };
                this._context.Bookings.Add(booking);
                this._context.SaveChanges();

            }
            else
            {
                return View(model);
            }


            return View();
        }

         
    


    [Authorize(Policy = "SignedIn")]
    [HttpGet, Route("booking/booking-services-feed")]
    public List<Service> FeedServices(int pageIndex)
    {
        int skip = (int)(3 * (pageIndex - 1));
        return this._context.Services
                            .Where(s => s.Id != null)
                            .OrderBy(s => s.CreatedAt)
                            .Skip(skip)
                            .Take(15)
                            .ToList();
    }





}
}