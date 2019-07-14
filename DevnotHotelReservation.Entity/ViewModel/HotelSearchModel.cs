using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevnotHotelReservation.Entity.ViewModel
{
    public class HotelSearchModel
    {
        public Hotel Hotel { get; set; }
        public HotelRoom HotelRoom { get; set; }
        public HotelRoomPrice HotelRoomPrice { get; set; }
        public HotelAddress HotelAddress { get; set; }
    }
}
