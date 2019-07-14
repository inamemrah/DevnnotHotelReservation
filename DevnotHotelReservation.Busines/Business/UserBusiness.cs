using DevnotHotelReservation.DAL.Repository;
using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevnotHotelReservation.Busines.Business
{
    public class UserBusiness
    {
        private HotelDBContext hotelDBContext;

        public UserBusiness()
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext = this.hotelDBContext;
        }

        public void SignUp(User user)
        {
            UserRepository userRepository = new UserRepository(hotelDBContext);

            userRepository.Insert(user);
        }

        public string Login(User user)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();

            var userInDb = hotelDBContext.User.FirstOrDefault(x => x.EmailAddress == user.EmailAddress && x.Password == user.Password);
            if(userInDb != null)
            {
                return "Giriş Başarılı";
            }
            else
            {
                return "Kullanıcı Adı veya Şifre Hatalı";
            }
        }
    }
}
