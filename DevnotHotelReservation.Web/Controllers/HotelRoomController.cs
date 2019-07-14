using DevnotHotelReservation.Busines.Business;
using Microsoft.AspNetCore.Mvc;

namespace DevnotHotelReservation.Web.Controllers
{
    public class HotelRoomController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult RoomPrices(int hotelRoomId)
        {
            HotelRoomBusiness hotelRoomBusiness = new HotelRoomBusiness();
            var hotelRoomPrice = hotelRoomBusiness.HotelRoomPrices(hotelRoomId);
            return View(hotelRoomPrice);
        }
    }
}