using System;
using System.Collections.Generic;
using System.Text;

namespace DevnotHotelReservation.DAL.Interface
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T GetById(int id);

        void Insert(T entity);

        void Update(T entity);

        void Delete(T id);

    }
}
