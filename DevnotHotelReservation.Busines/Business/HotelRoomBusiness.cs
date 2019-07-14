using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DevnotHotelReservation.DAL.Repository;

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
            HotelRoomRepository hotelRoomRepository = new HotelRoomRepository(hotelDBContext);
            var roomPrices = hotelRoomRepository.HotelRoomPrices(hotelRoomId);

            return roomPrices;

        }
    }
}
