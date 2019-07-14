using DevnotHotelReservation.DAL.Interface;
using DevnotHotelReservation.Entity.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevnotHotelReservation.DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private HotelDBContext dBContext;
        
        public Repository(HotelDBContext dBContext)
        {
            this.dBContext = new HotelDBContext();
            dBContext = this.dBContext;
        }

        public List<T> GetAll()
        {
            return dBContext.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return dBContext.Set<T>().Find(id);
        }

        public void Insert(T entity)
        {
            dBContext.Set<T>().Add(entity);
            dBContext.SaveChanges();
        }

        public void Update(T entity)
        {
            dBContext.Set<T>().Update(entity);
            dBContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            dBContext.Set<T>().Remove(entity);
            dBContext.SaveChanges();
        }
    }
}
