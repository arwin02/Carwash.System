using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Areas.Manage.ViewModels.calendars;
using CarWash.Web.Infrastructures.Domain.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarWash.Web.Areas.Manage.Controllers
{
    [Area("manage")]
    public class CalendarsController : Controller
    {

        private readonly DefaultDbContext _context;
        public CalendarsController(DefaultDbContext context)
        {
            _context = context;
        }

        //[Authorize(Policy = "SignedIn")]
        [HttpGet, Route("manage/calendars/index")]
        public IActionResult Index()
        {
            return View(new TimeTableViewModel());
        }

        [HttpGet, Route("/calendars/get-events")]
        public IActionResult GetEvents()
        {
            var events = new List<TimeTableViewModel>();
            var timeTableView = new TimeTableViewModel();
            var bookings = this._context.Bookings.ToList().OrderByDescending(b => b.UpdatedAt);


            foreach (var item in bookings)
            {

                timeTableView.BookingId = item.Id;
                timeTableView.ServiceId = item.ServiceId;
                timeTableView.Service = this._context.Services.FirstOrDefault(ss => ss.Id == item.ServiceId);
                timeTableView.UserName = item.UserName;
                timeTableView.Title = item.Title;
                timeTableView.Description = item.Description;
                timeTableView.Price = item.Price;
                timeTableView.BookingStatus = item.BookingStatus;
                timeTableView.PaymentType = item.PaymentType;
                timeTableView.ServiceType = item.ServiceType;
                timeTableView.VehicleType = item.VehicleType;
                timeTableView.UserName = item.UserName;
                timeTableView.PhoneNumber = item.PhoneNumber;
                timeTableView.Email = item.Email;
                timeTableView.Start = item.UpdatedAt.ToString();
                timeTableView.End = item.Time;
            
                events.Add(timeTableView);

            }

            //string json = JsonConvert.SerializeObject(events);
            return new JsonResult(JsonConvert.SerializeObject(events));

        }

    }
}