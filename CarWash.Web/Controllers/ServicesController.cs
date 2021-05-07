using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.ViewModels.services;
using Microsoft.AspNetCore.Mvc;

namespace CarWash.Web.Controllers
{
    public class ServicesController : Controller
    {
      
        private readonly DefaultDbContext _context;


        public ServicesController(DefaultDbContext context)
        {
            _context = context;
           
        }


        [HttpGet, Route("/services")]
        [HttpGet, Route("/services/index")]
        public IActionResult Index(int pageSize = 9, int pageIndex = 1, string keyword = "")
        {

            Page<Service> result = new Page<Service>();

            if (pageSize < 1)
            {
                pageSize = 1;
            }

            IQueryable<Service> serviceQuery = (IQueryable<Service>)this._context.Services;

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
              
            });
        }


        [HttpGet,Route("services/details/{id}")]
        public IActionResult Details(Guid? id)
        {
            if(id == null)
            {
                return RedirectToAction("index");
            }
            var service = this._context.Services.FirstOrDefault(s => s.Id == id);
            if(service == null)
            {
                return NotFound();
            }

            return View(new DetailViewModel
            {
                Service = service,
            });
        }

    }
}