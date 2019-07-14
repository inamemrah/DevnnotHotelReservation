using DevnotHotelReservation.DAL.Repository;
using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DevnotHotelReservation.Busines.Business
{
    public class HotelBusiness
    {

        private HotelDBContext hotelDBContext;

        public HotelBusiness()
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext = this.hotelDBContext;
        }

        public List<Hotel> GetAllHotels()
        {
            HotelRepository hotelRepository = new HotelRepository(hotelDBContext);

            var hotels = hotelRepository.GetAll();

            return hotels;
        }

        public List<Hotel> GetHotelDetails(int hotelId)
        {
            HotelRepository hotelRepository = new HotelRepository(hotelDBContext);

            var hotelDetails = hotelRepository.GetHotelDetails(hotelId);

            return hotelDetails;
        }
    }
}
