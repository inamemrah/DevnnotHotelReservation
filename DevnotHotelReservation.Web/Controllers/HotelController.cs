using DevnotHotelReservation.Busines.Business;
using Microsoft.AspNetCore.Mvc;
using System;

namespace DevnotHotelReservation.Web.Controllers
{
    public class HotelController : Controller
    {

        public IActionResult Index()
        {
            HotelBusiness hotelBusiness = new HotelBusiness();
            var hotels = hotelBusiness.GetHotels();

            return View(hotels);
        }

        public IActionResult HotelDetails(int id)
        {
            HotelBusiness hotelBusiness = new HotelBusiness();
            var details = hotelBusiness.GetHotelDetails(id);

            return View(details);
        }

        [HttpPost]
        public IActionResult HotelSearch(DateTime startDate)
        {
            HotelSearchBusiness hotelSearchBusiness = new HotelSearchBusiness();
            var search = hotelSearchBusiness.HotelSearch(startDate);

            return View(search);
        }
    }
}