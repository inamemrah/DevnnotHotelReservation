using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevnotHotelReservation.Busines.Business
{
    public class HotelRoomBusiness
    {
        private HotelDBContext hotelDBContext;

        public HotelRoomBusiness()
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext = this.hotelDBContext;
        }

        public List<HotelRoomPrice> HotelRoomPrices(int hotelRoomId)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();

            var query = (from hotelRoomPrice in hotelDBContext.HotelRoomPrice
                         where hotelRoomPrice.HotelRoomId == hotelRoomId
                         select hotelRoomPrice).ToList();
            return query;

        }
    }
}
