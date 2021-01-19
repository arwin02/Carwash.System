using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CarWash.Web.Models;
using CarWash.Web.ViewModels.home;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.Infrastructures.Domain.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Hosting;

namespace CarWash.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        public HomeController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;



        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpGet, Route("/home/pricing")]
        public IActionResult Pricing()
        {
            return View();
        }

        [HttpGet,Route("/home/faqs")]
        public IActionResult FAQS()
        {
            return View();
        }
        

        [HttpGet, Route("/home/about")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [HttpGet, Route("/home/ourservices")]
        public IActionResult OurServices()
        {

            return View();
        }


        [HttpGet, Route("/home/team")]
        public IActionResult Team()
        {
          

            return View();
        }


        [HttpGet,Route("/home/contact")]
        public IActionResult Contact()
        {
         

            return View();
        }

        [HttpPost,Route("/home/contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }


            Contact contact = new Contact()
            {
                Name = model.Name,
                EmailAddress = model.EmailAddress,
                Id = Guid.NewGuid(),
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
                Subject = model.Subject,
                Message = model.Message,

            };

            this._context.Contacts.Add(contact);
            this._context.SaveChanges();



            return RedirectToAction("~/home");
        }

        [HttpGet,Route("~/home/thank-you")]
        public IActionResult ThankYou()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
