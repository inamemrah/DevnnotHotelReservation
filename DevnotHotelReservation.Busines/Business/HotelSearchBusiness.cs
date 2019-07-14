using DevnotHotelReservation.Entity.Model;
using DevnotHotelReservation.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevnotHotelReservation.Busines.Business
{
    public class HotelSearchBusiness
    {
        private HotelDBContext hotelDBContext;

        public HotelSearchBusiness()
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext = this.hotelDBContext;
        }

        public List<HotelSearchModel> HotelSearch(DateTime startDate)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();

            var query = (from hotelRoomPrice in hotelDBContext.HotelRoomPrice
                         join hotelRoom in hotelDBContext.HotelRoom
                         on hotelRoomPrice.HotelRoomId equals hotelRoom.Id
                         join hotel in hotelDBContext.Hotel
                         on hotelRoom.HotelId equals hotel.Id
                         join hotelAddress in hotelDBContext.HotelAddress
                         on hotel.Id equals hotelAddress.HotelId
                         where hotelRoomPrice.StartDate <= startDate && hotelRoomPrice.EndDate >= startDate
                         select new HotelSearchModel {
                             Hotel = hotel,
                             HotelRoom = hotelRoom,
                             HotelRoomPrice = hotelRoomPrice,
                             HotelAddress = hotelAddress
                         }).ToList();

            return query;
        }
    }
}
