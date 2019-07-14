using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DevnotHotelReservation.DAL.Interface;

namespace DevnotHotelReservation.DAL.Repository
{
    public class HotelRepository : Repository<Hotel>
    {
        private HotelDBContext hotelDBContext;

        public HotelRepository(HotelDBContext hotelDBContext) : base(hotelDBContext)
        {
            hotelDBContext = this.hotelDBContext;
        }
    }
}
