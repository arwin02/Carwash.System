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


        [HttpGet,Route("~/booking/index")]
        public IActionResult Index()
        {
            //retrieving data in database including services data.
            var bookings = _context.Bookings.Include(c => c.Services).ToList();
            return View(new IndexViewModel
            {
                Bookings = bookings,
            });
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet,Route("/booking/bookings-costumer/{costumerId}")]
        public IActionResult Bookings (Guid? costumerId)
        {

            var user = this._context.Users.FirstOrDefault(u => u.Id == costumerId);
            if(user == null)
            {
                ModelState.AddModelError("", "Please login your account before booking");
                return RedirectToPage("~/account/login");
            }

            var bookings = _context.Bookings.Include(c => c.Services).ToList();
            return View(new BookingsViewModel
            {
                Bookings = bookings
                //Services = FeedServices(1)

            });
        }


        //[Authorize(Policy = "SignedIn")]
        //[HttpGet, Route("booking/booking-services-feed")]
        //public List<Service> FeedServices(int pageIndex)
        //{
        //    int skip = (int)(3 * (pageIndex - 1));
        //    return this._context.Services
        //                        .Where(s => s.Id != null)
        //                        .OrderBy(s => s.CreatedAt)
        //                        .Skip(skip)
        //                        .Take(15)
        //                        .ToList();
        //}


        [Authorize(Policy = "SignedIn")]
        [HttpPost,Route("/booking/bookings-costumer")]
        public IActionResult Bookings(BookingsViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            var user = this._context.Users.FirstOrDefault(u => u.Id == WebUser.UserId);
            if (user != null)
            {
                Booking bookings = new Booking()
                {
                    Id = Guid.NewGuid(),
                    CostumerId = user.Id.Value,
                    ServiceType = model.ServiceType,
                    Vehicle = model.Vehicle,
                    BookingAddress = model.BookingAddress,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                    //hh:mm tt = 12:00 PM"
                    Time = model.Time,


                };

                this._context.Bookings.Add(bookings);
                this._context.SaveChanges();

            }

            return View();
        }


       
    }
}