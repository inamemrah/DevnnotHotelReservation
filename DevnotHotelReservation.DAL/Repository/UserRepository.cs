using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        public User Login(User user)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();

            var userInDb = hotelDBContext.User.FirstOrDefault(x => x.EmailAddress == user.EmailAddress && x.Password == user.Password);
            return userInDb;
        }
    }
}
