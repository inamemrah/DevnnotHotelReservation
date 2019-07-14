using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevnotHotelReservation.DAL.Repository
{
    public class HotelRoomRepository : Repository<HotelRoom>
    {
        private HotelDBContext hotelDBContext;

        public HotelRoomRepository(HotelDBContext hotelDBContext) : base(hotelDBContext)
        {
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
