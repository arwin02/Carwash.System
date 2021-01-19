using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Areas.Manage.ViewModels.services;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace CarWash.Web.Areas.Manage.Controllers
{


    [Area("manage")]
    [AllowAnonymous]
    public class ServicesController : Controller
    {

        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;


        public ServicesController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;


        }

        [HttpGet, Route("manage/service")]
        [HttpGet, Route("manage/service/index")]
        public IActionResult Index(int pageSize = 5, int pageIndex = 1, string keyword = "", string service = "Wash")
        {
            Enum.TryParse(service, out ServiceType serviceType); ;

            Page<Service> result = new Page<Service>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Service> serviceQuery = (IQueryable<Service>)this._context.Services.Where(s => s.ServiceType == serviceType);

            if (string.IsNullOrEmpty(keyword) == false)
            {
                serviceQuery = serviceQuery.Where(s => s.Vehicle.Contains(keyword));

            }

            long queryCount = serviceQuery.Count();

            int pageCount = (int)Math.Ceiling((decimal)(queryCount / pageSize));
            long mod = (queryCount % pageSize);

            if (mod > 0)
            {
                pageCount = pageCount + 1;
            }

            int skip = (int)(pageSize * (pageIndex - 1));
            List<Service> services = serviceQuery.ToList();

            result.Items = services.Skip(skip).Take((int)pageSize).ToList();
            result.PageCount = pageCount;
            result.PageSize = pageSize;
            result.QueryCount = queryCount;
            result.PageIndex = pageIndex;
            result.Keyword = keyword;

            return View(new IndexViewModel()
            {
                Services = result,
                ServiceT = serviceType
            });
        }

        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/service/delete/{serviceId}")]
        public IActionResult Delete(Guid? serviceId)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);

            if (service != null)
            {
                this._context.Services.Remove(service);
                this._context.SaveChanges();
            }

            return RedirectToAction("index");
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/service/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var service = this._context.Services.FirstOrDefault(m => m.Id == id);
            if (service == null)
            {
                return NotFound();
            }

            return View(service);
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/service/create-services")]
        public IActionResult CreateService()
        {
            return View();
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpPost, Route("manage/service/create-services")]
        public IActionResult CreateService(CreateServiceViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }



            Service service = new Service()
            {

                Id = Guid.NewGuid(),
                Description = model.Description,
                ServiceType = model.ServiceType,
                Price = model.Price,
                Vehicle = model.Vehicle,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,



            };
            this._context.Services.Add(service);
            this._context.SaveChanges();


            return RedirectToAction("Index");

        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpGet, Route("manage/service/services-edit/{id}")]
        public IActionResult Edit(Guid? id)
        {
            var service = this._context.Services.FirstOrDefault(s => s.Id == id);

            if (service == null)
            {
                return RedirectToAction("Index");
            }


            if (service != null)
            {
                return View(
                    new EditServiceViewModel()
                    {
                        Id = service.Id.Value,
                        Vehicle = service.Vehicle,
                        Description = service.Description,
                        ServiceType = service.ServiceType,
                        Price = service.Price
                    }
                );
            }

            return View();
        }


        [AllowAnonymous]
        [Authorize(Policy = "AuthorizeAdmin")]
        [HttpPost, Route("manage/service/services-edit")]
        public IActionResult Edit(EditServiceViewModel model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var service = this._context.Services.FirstOrDefault(s => s.Id == model.Id);

            if (service != null)
            {
                service.Vehicle = model.Vehicle;
                service.Description = model.Description;
                service.ServiceType = model.ServiceType;
                service.Price = model.Price;

                this._context.Services.Update(service);
                this._context.SaveChanges();



                return RedirectToAction("Index", new { Id = model.Id });
            }

            return View();
        }
    }
}