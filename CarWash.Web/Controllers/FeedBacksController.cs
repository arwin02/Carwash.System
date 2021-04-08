using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarWash.Web.Infrastructures.Domain.Data;
using CarWash.Web.Infrastructures.Domain.Models;
using CarWash.Web.ViewModels.feedback;
using CarWash.Web.ViewModels.operation;
using Microsoft.AspNetCore.Mvc;

namespace CarWash.Web.Controllers
{
    public class FeedBacksController : Controller
    {

        private readonly DefaultDbContext _context;
        public FeedBacksController(DefaultDbContext context)
        {
            _context = context;

        }


        public IActionResult Index()
        {
            return View();
        }


        [HttpPost, Route("/feedback/add-comment-with-rating")]
        public IActionResult CommentWithRating(CommentWithRatingViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            var user = this._context.Users.FirstOrDefault(u => u.Id == model.UserId);
            var service = this._context.Services.FirstOrDefault(s => s.Id == model.ServiceId);

            if (service != null)
            {
                if(service.RatingsEnabled == true)
                {
                    var userRating = _context.Ratings.FirstOrDefault(r => r.UserId == model.UserId && r.ServiceId == model.ServiceId);
                    if (userRating == null)
                    {
                        userRating = new Infrastructures.Domain.Models.Rating()
                        {
                            Score = model.Score,
                            ServiceId = model.ServiceId,
                            UserId = model.UserId,
                            IsCounted = true,
                            MaskUser = false

                        };

                        _context.Ratings.Add(userRating);
                        _context.SaveChanges();
                    }
                }
                if(service.CommentsEnabled == true)
                {
                    var userComment = new Comment()
                    {
                        Content = model.Comment,
                        IsPublished = true,
                        ServiceId = model.ServiceId,
                        UserId = model.UserId,
                        MaskUser = false,
                        LikesEnabled = true,
                        Likes = 0,
                    };
                    _context.Comments.Add(userComment);
                    _context.SaveChanges();
                }
             
                return RedirectPermanent("~/booking/book/" + model.ServiceId);

            }
            return NotFound();
        }

        [HttpPost("feedback/likes")]
        public OperationViewModel AddDeductLike(LikeViewModel model)
        {
            var user = _context.Users.FirstOrDefault(p => p.Id == model.UserId);

            var service = _context.Services.FirstOrDefault(p => p.Id == model.ServiceId);

            if (service != null)
            {
                if (service.LikesEnabled == true)
                {
                    var userLike = _context.Likes.FirstOrDefault(r => r.UserId == model.UserId && r.ServiceId == model.ServiceId);
                    if (userLike == null && model.IsLiked)
                    {
                        userLike = new Like()
                        {
                            ServiceId = model.ServiceId,
                            UserId = model.UserId,
                        };

                        _context.Likes.Add(userLike);

                        service.Likes = service.Likes + 1;
                        _context.Services.Update(service);
                    }
                    else if (userLike != null && model.IsLiked == false)
                    {
                        _context.Likes.Remove(userLike);

                        service.Likes = service.Likes - 1;
                        _context.Services.Update(service);
                    }
                    else
                    {

                    }
                    _context.SaveChanges();

                    return new OperationViewModel()
                    {
                        Code = "Ok",
                        Data = new { Likes = service.Likes, IsLiked = model.IsLiked }
                    };
                }
                else
                {
                    return new OperationViewModel()
                    {
                        Code = "Fail",
                        Messages = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("", "Likes are disabled for this item.") },
                        Data = new { Likes = service.Likes, IsLiked = false }
                    };

                }

            }
            else
            {
                return new OperationViewModel()
                {
                    Code = "Fail",
                    Messages = new List<KeyValuePair<string, string>>() { new KeyValuePair<string, string>("", "Target shop is not found.") },
                    Data = new { IsLiked = false }
                };
            }
        }
    }

}
