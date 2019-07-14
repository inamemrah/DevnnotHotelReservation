using DevnotHotelReservation.DAL.Repository;
using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevnotHotelReservation.Busines.Business
{
    public class HotelCommentBusiness
    {
        private HotelDBContext hotelDBContext;

        public HotelCommentBusiness()
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            hotelDBContext = this.hotelDBContext;
        }

        public void AddComment(string Comment, int Score, int Id, int UserId)
        {
            HotelCommentRepository hotelCommentRepository = new HotelCommentRepository(hotelDBContext);

            HotelComment hotelComment = new HotelComment
            {
                Comment = Comment,
                Score = Score,
                HotelId = Id,
                UserId = UserId

            };

            hotelCommentRepository.Insert(hotelComment);
        }
    }
}
