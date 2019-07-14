using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevnotHotelReservation.DAL.Repository
{
    public class HotelCommentRepository : Repository<HotelComment>
    {
        private HotelDBContext hotelDBContext;

        public HotelCommentRepository(HotelDBContext hotelDBContext) : base(hotelDBContext)
        {
            hotelDBContext = this.hotelDBContext;
        }
    }
}
