using DevnotHotelReservation.Entity.Model;
using DevnotHotelReservation.Entity.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DevnotHotelReservation.DAL.Repository;

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
            HotelRepository hotelRepository = new HotelRepository(hotelDBContext);
            var hotel = hotelRepository.HotelSearch(startDate);

            return hotel;
        }
    }
}
