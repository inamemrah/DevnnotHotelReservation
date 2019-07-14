using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevnotHotelReservation.Busines.Business;
using DevnotHotelReservation.Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevnotHotelReservation.Web.Controllers
{
    public class HotelCommentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddComment(string Comment, int Score, int Id)
        {
            HotelCommentBusiness hotelCommentBusiness = new HotelCommentBusiness();

            int UserId = Convert.ToInt32(HttpContext.Session.GetInt32("UserId"));

            hotelCommentBusiness.AddComment(Comment, Score, Id, UserId);

            return RedirectToAction("Index", "Hotel");
        }
    }
}