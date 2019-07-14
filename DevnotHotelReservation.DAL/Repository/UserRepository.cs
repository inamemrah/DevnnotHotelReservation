using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevnotHotelReservation.DAL.Repository
{
    public class UserRepository : Repository<User>
    {
        private HotelDBContext hotelDBContext;

        public UserRepository(HotelDBContext hotelDBContext) : base(hotelDBContext)
        {
            hotelDBContext = this.hotelDBContext;
        }
    }
}
