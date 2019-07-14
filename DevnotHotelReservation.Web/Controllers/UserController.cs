using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevnotHotelReservation.Busines.Business;
using DevnotHotelReservation.DAL.Repository;
using DevnotHotelReservation.Entity.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DevnotHotelReservation.Web.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignUp(User user)
        {
            UserBusiness userBusiness = new UserBusiness();
            userBusiness.SignUp(user);
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User user)
        {
            UserBusiness userBusiness = new UserBusiness();
            var userInDb = userBusiness.Login(user);

            if(userInDb != null)
            {
                HttpContext.Session.SetString("User", userInDb.UserName);

                return RedirectToAction("Index","Hotel");
            }

            else
            {
                ViewBag.Message = "Kullanıcı Adı veya Şifre Hatalı";
                return View();
            }

        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("User");
            return RedirectToAction("Index", "Hotel");
        }
        
        
    }
}