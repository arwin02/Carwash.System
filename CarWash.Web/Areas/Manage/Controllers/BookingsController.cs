using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Areas.Manage.ViewModels.bookings;
using CarWash.Web.Controllers;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Configuration;


namespace CarWash.Web.Areas.Manage.Controllers
{


    [Area("manage")]
    [AllowAnonymous]
    public class BookingsController : Controller
    {
        private readonly IHubContext<SignalHub> _hubContext;
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;


        public BookingsController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env, IHubContext<SignalHub> hubContext)
        {
            _context = context;
            _config = config;
            _env = env;
            _hubContext = hubContext;


        }
        
   
        [HttpGet,Route("manage/booking")]
        [HttpGet,Route("manage/booking/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string booking = "Wash")
        {
            Enum.TryParse(booking, out ServiceType serviceType); ;

            Page<Booking> result = new Page<Booking>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Booking> bookingQuery = (IQueryable<Booking>)this._context.Bookings.Where(s => s.ServiceType == serviceType);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                bookingQuery = bookingQuery.Where(s => s.Title.Contains(keyword));

            }

            long queryCount = bookingQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Booking> bookings = bookingQuery.ToList();

            result.Items = bookings.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

        
            return View(new IndexViewModel()
            {
                Bookings = result,
                ServiceT = serviceType
            });
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/booking/create-bookings")]
        public IActionResult CreateBooking(Guid? id)
        {
            return View();
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpPost, Route("manage/booking/create-bookings")]
        public IActionResult CreateBooking(CreateBookingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }


            var user = this._context.Users.FirstOrDefault(u => u.Id == model.CostumerId);

            if(user != null)
            {
                Booking booking = new Booking()
                {

                    Id = Guid.NewGuid(),
                    Time = model.Time,
                    BookingAddress = model.BookingAddress,
                    UserId = model.CostumerId,
                    ServiceType = model.ServiceType,
                    Title = model.Vehicle,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,



                };
                this._context.Bookings.Add(booking);
                this._context.SaveChanges();
            }
           


            return RedirectToAction("Index");

        }

        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/booking/delete/{bookingId}")]
        public IActionResult Delete(Guid? bookingId)
        {
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);

            if (booking != null)
            {
                this._context.Bookings.Remove(booking);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/booking/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == id);
            if (booking == null)
            {
                return NotFound();
            }

            return View(booking);
        }




        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/booking/bookings-edit/{id}")]
        public IActionResult Edit(Guid? id)
        {
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == id);

            if (booking == null)
            {
                return RedirectToAction("Index");
            }


            if (booking != null)
            {
                return View(
                    new EditViewModel()
                    {
                        Id = booking.Id.Value,
                        Vehicle = booking.Title,
                       Time = booking.Time,
                       BookingAddress = booking.BookingAddress,
                        ServiceType = booking.ServiceType,
                                        
                    }
                );
            }

            return View();
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpPost, Route("manage/booking/bookings-edit")]
        public IActionResult Edit(EditViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == model.Id);

            if (booking != null)
            {
                booking.Title = model.Vehicle;
                booking.Time = model.Time;
                booking.BookingAddress = model.BookingAddress;
                booking.ServiceType = model.ServiceType;


                this._context.Bookings.Update(booking);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }

        [HttpPost("/manage/booking/change-status")]
        public async Task<IActionResult> ChangeStatus(ChangeStatusViewModel model)
        {
            var booking = _context.Bookings.FirstOrDefault(p => p.Id == model.BookingId);

            if (booking != null)
            {
                booking.BookingStatus = model.Status;

                _context.Bookings.Update(booking);
                _context.SaveChanges();
            }
            //Post to Hub
            await _hubContext.Clients.All.SendAsync("ReceiveNotification",  booking.UserId, "Your booking " + booking.Title + " has been updated to " + booking.BookingStatus + "date of" + booking.UpdatedAt);


            return RedirectPermanent("~/manage/booking/index");
        }
    }
}