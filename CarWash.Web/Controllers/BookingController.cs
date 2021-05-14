using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Enums;
using CarWash.Web.Infrastructures.Domain.Helpers;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.RecaptchaValidator;
using CarWash.Web.ViewModels.bookings;
using CarWash.Web.ViewModels.payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;
using SixLabors.ImageSharp.Processing;

namespace CarWash.Web.Controllers
{
    public class BookingController : Controller
    {
        public decimal TotalPrice { get; private set; }
        private readonly DefaultDbContext _context;
        protected readonly IConfiguration _config;
        private IHostingEnvironment _env;

        public BookingController(DefaultDbContext context, IConfiguration config, IHostingEnvironment env)
        {
            _context = context;
            _config = config;
            _env = env;
        }


        public IActionResult ServiceSummary()
        {
            return View();
        }
   
        [HttpGet,Route("booking/book/{serviceId}")]
        public IActionResult Book(Guid? serviceId)
        {
            Guid? userId = WebID.GetPublicUserId;
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);
            if (service != null)
            {
                var comments = _context.Comments.Where(c => c.ServiceId == serviceId && c.IsPublished == true)
                                                .OrderByDescending(c => c.UpdatedAt)
                                                .Take(3)
                                                .Select(c => new CommentViewModel()
                                                {
                                                    Id = c.Id,
                                                    UserId = c.UserId,
                                                    Content = c.Content,
                                                    Likes = c.Likes,
                                                    UserName = (c.MaskUser == true ? c.UserName : c.User.LastName),
                                                    UserIcon = (c.MaskUser == true ? "user.svg" : c.User.Id.ToString() + ".jpeg"),
                                                    UpdatedAt = c.UpdatedAt

                                                }).ToList();
                var commentCount = 0;
                commentCount = comments.Count;

                var ratings = _context.Ratings.Where(r => r.ServiceId == serviceId && r.IsCounted == true).ToList();
                decimal ratingAve = 0;

                if (ratings != null)
                {
                    if (ratings.Count > 0)
                    {
                        ratingAve = ratings.Average(r => r.Score);
                    }
                }

                var isLiked = false;
                var liked = _context.Likes.FirstOrDefault(l => l.ServiceId == serviceId && l.UserId == userId);

                if (liked != null)
                {
                    isLiked = true;
                }

                return View(new BookViewModel()
                {
                    Id = service.Id,
                    UserId = user.Id,
                    ServiceType = service.ServiceType,
                    Vehicle = service.Vehicle,
                    Description = service.Description,
                    Price = service.Price,
                    CommentItems = comments,
                    Comments = commentCount,
                    RatingAve = ratingAve,
                    IsLiked = isLiked,
                    Likes = service.Likes
                });
            }
            return NotFound();
        }


        [Authorize(Policy = "SignedIn")]
        [HttpGet, Route("/booking/costumer/{serviceId}")]
        public IActionResult BookingWithService(Guid? serviceId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetPublicUserId);
            var service = this._context.Services.FirstOrDefault(s => s.Id == serviceId);
            if (user == null)
            {
                if (service == null)
                {
                    return BadRequest();
                }
              
            }
          
            return View(new BookingsViewModel
            {
                User =user,
                Service = service
                
            });
        }

        [Authorize(Policy = "SignedIn")]
        [HttpPost, Route("/booking/costumer-service")]
        public IActionResult BookingWithService(PostAutoBookingViewModel model)
        {
            string EncodedResponse = Request.Form["g-recaptcha-response"];
            var isCaptchaValid = Recaptcha.Validate(EncodedResponse);


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Guid? Id = null;

            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);

            var service = this._context.Services.FirstOrDefault(s => s.Id == model.ServiceId);
            if (isCaptchaValid)
            {
                if (user != null)
                {
                    if (service != null)
                    {
                        Booking booking = new Booking()
                        {
                            Id = Guid.NewGuid(),
                            ServiceId = model.ServiceId,
                            UserId = model.UserId,
                            UserName = user.UserName,
                            PhoneNumber = model.PhoneNumber,
                            Email = model.Email,
                            BookingAddress = model.BookingAddress,
                            Time = model.Time,
                            Title = service.Vehicle,
                            Description = service.Description,
                            Price = service.Price,
                            ServiceType = service.ServiceType,
                            ItemTotal = 1,
                            BookingStatus = Infrastructures.Domain.Enums.BookingStatus.Pending,
                            PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid,
                            CreatedAt = DateTime.UtcNow,
                            UpdatedAt = DateTime.UtcNow,

                        };

                        Id = booking.Id;
                        this._context.Bookings.Add(booking);

                        service.RatingsEnabled = true;
                        service.LikesEnabled = true;
                        service.CommentsEnabled = true;

                        this._context.Services.Update(service);
                        this._context.SaveChanges();
                    }


                }
            }
            else
            {
                ModelState.AddModelError("", "Error From Google ReCaptcha :" + isCaptchaValid);
                return View();
            }
           
            if(Id != null)
            {
                return Content(@"/booking/book-review/" + Id);
            }

            return Content(@"/services/index");
            //return Redirect("/feedback/user-feedbacks/" + model.UserId + "/" + model.ServiceId);

        }

        [HttpGet,Route("/booking/greetings")]
        public IActionResult Greetings()
        {
            return View();
        }

        [HttpGet,Route("/booking/phase-one-booking/{userId}")]
        public IActionResult PhaseOne(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            if (user == null)
            {
                return BadRequest();
            }
            return View(new PhaseOneViewModel()
            {
                UserId = userId
            });
        }
        [HttpPost, Route("/booking/phase-one-booking")]
        public IActionResult PhaseOne(PhaseOneViewModel model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }
            Guid? _id = null;
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            if(user != null)
            {
                var booking = new Booking
                {
                    Id = Guid.NewGuid(),
                    VehicleType = model.VehicleType,
                    UserId = model.UserId,
                    UpdatedAt = DateTime.UtcNow,
                    CreatedAt = DateTime.UtcNow
                };
                _id = booking.Id;

                this._context.Bookings.Add(booking);
                this._context.SaveChanges();


            }
             //return Redirect("/booking/phase-two-booking/" + model.UserId);
            return Content(@"/booking/phase-two-booking/"+ _id);

        }


        [HttpGet, Route("/booking/phase-two-booking/{bookingId}")]
        public IActionResult PhaseTwo(Guid? bookingId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == WebID.GetPublicUserId);
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);


            //var ItemServices = this._context.Bookings.Where(b => b.UserId == user.Id).Include(b => b.Service)
            //                                .OrderByDescending(b => b.UpdatedAt)
            //                                .ToList();
            if (user == null)
            {
                return BadRequest();
            }
            if(booking == null)
            {
                return BadRequest();
            }
            return View(new PhaseTwoViewModel()
            {
                BookingId = booking.Id,
                UserId = user.Id,
              
                
            });
        }

        [HttpPost, Route("/booking/add-service-item")]
        public IActionResult PhaseTwoAddItemService(AddServiceItemViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            Guid? _id = null;

            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            var service = this._context.Services.FirstOrDefault(s => s.Id == model.ServiceId);
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == model.BookingId);

            if(user != null)
            {
                if (service != null)
                {
                    if (booking != null)
                    {

                        booking.ServiceId = model.ServiceId;
                        booking.Price = service.Price;
                        booking.Description = service.Description;
                        booking.ServiceType = service.ServiceType;
                        booking.Title = service.Vehicle;
                        booking.ItemTotal = 1;
                        booking.BookingStatus = Infrastructures.Domain.Enums.BookingStatus.Pending;
                        booking.PaymentType = Infrastructures.Domain.Enums.PaymentType.Unpaid;

                        this._context.Bookings.Update(booking);
                        this._context.SaveChanges();

                        _id = booking.Id;
                    }


                }

            }
           
            return Content(@"/booking/phase-three-booking/" + model.UserId + "/" + _id);
           
        }

       

        [HttpGet,Route("/booking/services-indiv-per-type/{type}")]
        public List<ServiceIndivListViewModel> GetServices(string type = "")
        {
            if(string.IsNullOrEmpty(type))
            {
                return null;
            }
            ServiceType serviceType = (ServiceType)Enum.Parse(typeof(ServiceType), type, true);

            return _context.Services.Where(s => s.ServiceType == serviceType)
                .Select(s => new ServiceIndivListViewModel()
                {
                    Id = s.Id,
                    Description = s.Description,
                    Price = s.Price,
                    Vehicle = s.Vehicle,
                    ServiceType = s.ServiceType,
                    UpdatedAt = s.UpdatedAt,

                }).ToList();
        }

        [HttpGet, Route("/booking/phase-three-booking/{userId}/{bookingId}")]
        public IActionResult PhaseThree(Guid? userId,Guid? bookingId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);
                                           
            if (user == null)
            {
                if (booking == null)
                {
                    return BadRequest();
                }
              
            }
          

            return View(new PhaseThreeViewModel()
            {
                User = user,
                Booking = booking
            });
        }

        [HttpGet,Route("/booking/delete-item/{bookingId}/{userId}/{serviceId}")]
        public IActionResult DeleteItem(Guid? bookingId,Guid? userId,Guid? serviceId)
        {
   
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);
            if(booking != null)
            {
                this._context.Bookings.Remove(booking);
                this._context.SaveChanges();
            }


            return RedirectPermanent("~/services/index");
        }

        [HttpGet,Route("/booking/empty-items/{userId}")]
        public IActionResult EmptyItems(Guid? userId)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == userId);

            var Items = this._context.Bookings.Where(b => b.UserId == user.Id);
            foreach(var items in Items)
            {
                this._context.Bookings.Remove(items);

            }
            this._context.SaveChanges();

            return Redirect("~/services/index");
        }



        [HttpPost, Route("/booking/phase-three-booking")]
        public IActionResult PhaseThree(PhaseThreePostViewModel model)
        {
            string EncodedResponse = Request.Form["g-recaptcha-response"];
            var isCaptchaValid = Recaptcha.Validate(EncodedResponse);


            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == model.BookingId);

            if (isCaptchaValid)
            {
                if (user != null)
                {
                    if (booking != null)
                    {
                        booking.UserName = user.UserName;
                        booking.PhoneNumber = model.PhoneNumber;
                        booking.Email = model.Email;
                        booking.Time = model.Time;
                        booking.BookingAddress = model.Address;

                        this._context.Bookings.Update(booking);
                        this._context.SaveChanges();
                    }

                }
            }
            else
            {
                ModelState.AddModelError("", "Error From Google ReCaptcha :" + isCaptchaValid);
                return View();
            }
          
            //return Content(@"/home/service-book/" + model.UserId);
            //return Content(@"/feedback/user-feedbacks/" + model.UserId + "/" + model.ServiceId );
            return Content(@"/booking/book-review/" + booking.Id);
        }



        [HttpGet,Route("/booking/book-review/{bookingId}")]
        public IActionResult BookReview(Guid? bookingId)
        {

            var booking = this._context.Bookings.FirstOrDefault(b => b.Id == bookingId);

            var bookings = this._context.Bookings.Where(b => b.Id == bookingId)
                                                 .OrderByDescending(b => b.UpdatedAt == DateTime.Today)
                                                 .ToList();

            return View(new ReviewBookingViewModel
            {
                Booking = booking,
                Bookings = bookings
            });
        }

        [HttpGet,Route("~/booking/payment-gateway")]
        public IActionResult Payment()
        {
            return View();
        }

        [HttpPost, Route("/booking/payment-image")]
        public async Task<IActionResult> PaymentGateway(PaymentGatewayViewModel model)
        {
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            if (user != null)
            {
                //Check file size of the uploaded thumbnail
                //reject if the file is greater than 2mb
                var fileSize = model.PaymentImage.Length;
                if ((fileSize / 1048576.0) > 14)
                {
                    ModelState.AddModelError("", "The file you uploaded is too large. Filesize limit is 14mb.");
                    return View(model);
                }
                //Check file type of the uploaded thumbnail
                //reject if the file is not a jpeg or png
                if (model.PaymentImage.ContentType != "image/jpeg" && model.PaymentImage.ContentType != "image/png")
                {
                    ModelState.AddModelError("", "Please upload a jpeg or png file for the thumbnail.");
                    return View(model);
                }
                //Formulate the directory where the file will be saved
                //create the directory if it does not exist
                var dirPath = _env.WebRootPath + "/images/payments-gateway/" + model.UserId.ToString();
                if (!Directory.Exists(dirPath))
                {
                    Directory.CreateDirectory(dirPath);
                }
                //always name the file thumbnail.png
                var filePath = dirPath + "/payment-gateway.png";
                if (model.PaymentImage.Length > 0)

                {
                    //Open a file stream to read all the file data into a byte array
                    byte[] bytes = await FileBytes(model.PaymentImage.OpenReadStream());
                    //load the file into the third party (ImageSharp) Nuget Plugin                
                    using (Image<Rgba32> image = Image.Load(bytes))
                    {
                        //use the Mutate method to resize the image 150px wide by 150px long
                        image.Mutate(x => x.Resize(400, 700));
                        //save the image into the path formulated earlier
                        image.Save(filePath);
                    }
                }
              

                return RedirectToAction("Payment");
            }

            return NotFound();
        }


        #region Helpers
       
        public async Task<byte[]> FileBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        #endregion

        private decimal CalculateTotalPrice()
        {
            var bookings = this._context.Bookings;

            var totalPrice = 0m;
            foreach (var book in bookings)
            {
                totalPrice += book.Price;
            }
            return totalPrice;
        }

        private void RecalculateTotalPrice()
        {
            var bookings = this._context.Bookings;
            var totalPrice = 0m;
            foreach (var book in bookings)
            {
                totalPrice += book.Price;
            }
            TotalPrice = totalPrice;
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