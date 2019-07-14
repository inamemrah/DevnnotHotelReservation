using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DevnotHotelReservation.DAL.Interface;
using DevnotHotelReservation.Entity.ViewModel;

namespace DevnotHotelReservation.DAL.Repository
{
    public class HotelRepository : Repository<Hotel>
    {
        private HotelDBContext hotelDBContext;

        public HotelRepository(HotelDBContext hotelDBContext) : base(hotelDBContext)
        {
            hotelDBContext = this.hotelDBContext;
        }
        

        public List<HotelSearchModel> HotelSearch(DateTime startDate)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();

            var query = (from hotelRoomPrice in hotelDBContext.HotelRoomPrice
                         join hotelRoom in hotelDBContext.HotelRoom
                         on hotelRoomPrice.HotelRoomId equals hotelRoom.Id
                         join hotel in hotelDBContext.Hotel
                         on hotelRoom.HotelId equals hotel.Id
                         join hotelAddress in hotelDBContext.HotelAddress
                         on hotel.Id equals hotelAddress.HotelId
                         where hotelRoomPrice.StartDate <= startDate && hotelRoomPrice.EndDate >= startDate
                         select new HotelSearchModel
                         {
                             Hotel = hotel,
                             HotelRoom = hotelRoom,
                             HotelRoomPrice = hotelRoomPrice,
                             HotelAddress = hotelAddress
                         }).ToList();

            return query;
        }

        public List<Hotel> GetHotelDetails(int hotelId)
        {
            HotelDBContext hotelDBContext = new HotelDBContext();
            var query =
                       (from hotel in hotelDBContext.Hotel
                        where hotel.Id == hotelId
                        select new Hotel
                        {
                            Name = hotel.Name,
                            Description = hotel.Description,
                            Id = hotel.Id,
                            MainImage = hotel.MainImage,
                            HotelAddress = (from hotelAddress in hotelDBContext.HotelAddress
                                            where hotelAddress.HotelId == hotelId
                                            select hotelAddress).ToList(),

                            HotelComment = (from hotelComment in hotelDBContext.HotelComment
                                            join user in hotelDBContext.User
                                            on hotelComment.UserId equals user.Id
                                            where hotelComment.HotelId == hotelId
                                            select new HotelComment
                                            {
                                                User = user,
                                                Comment = hotelComment.Comment,
                                                HotelId = hotelComment.HotelId,
                                                Score = hotelComment.Score
                                            }).ToList(),

                            HotelContact = (from hotelContact in hotelDBContext.HotelContact
                                            join hotelContactType in hotelDBContext.HotelContactType
                                            on hotelContact.HotelContactTypeId equals hotelContactType.Id
                                            where hotelContact.HotelId == hotelId
                                            select new HotelContact
                                            {
                                                ContactValue = hotelContact.ContactValue,
                                                HotelContactType = new HotelContactType()
                                                {
                                                    Name = hotelContactType.Name
                                                }
                                            }).ToList(),

                            HotelRoom = (from hotelRoom in hotelDBContext.HotelRoom
                                         join roomType in hotelDBContext.RoomType
                                         on hotelRoom.RoomTypeId equals roomType.Id
                                         where hotelRoom.HotelId == hotelId
                                         select new HotelRoom
                                         {
                                             RoomDetail = hotelRoom.RoomDetail,
                                             RoomSummary = hotelRoom.RoomSummary,
                                             Id = hotelRoom.Id,
                                             RoomType = new RoomType()
                                             {
                                                 Id = roomType.Id,
                                                 TypeName = roomType.TypeName
                                             }
                                         }).ToList(),

                            HotelImage = (from hotelImage in hotelDBContext.HotelImage
                                          where hotelImage.HotelId == hotelId
                                          select hotelImage).ToList(),

                            HotelScore = (from hotelScore in hotelDBContext.HotelScore
                                          where hotelScore.HotelId == hotelId
                                          select hotelScore).ToList()
                        }).ToList();

            return query;
        }
    }
}
