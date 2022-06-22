using Microsoft.EntityFrameworkCore;
using MyAssignment.Services;
using System.Collections.Generic;

using System.Linq;

namespace MyAssignment.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : class
    {
        protected MyDbContext db;
        public BaseRepository(MyDbContext db)
        {
            this.db = db;
        }
        public T Get(int id)
            
        {
            var dataToGet = db.Set<T>().Find(id);
            if(dataToGet == null)
            {
                throw new System.Exception("Data not found");
            }
            return dataToGet;
        }
        public bool Delete(int id)
        {
            var itemToRemove = this.Get(id);
            if(itemToRemove == null)
            {
                throw new System.Exception("There is no such id that you are searching for");
            }
            
            db.Set<T>().Remove(itemToRemove);
            return true;
        }
        public bool Add(T entity)

        {
            var dataTooAdd=db.Set<T>().Add(entity);

            db.SaveChanges();
            return true;
        }

       

        public virtual ICollection<T> Get() 
        {

            var data = db.Set<T>().ToList();                                  
            return data;
        }

      

        public virtual T Search(int id)
        {
            var dataToGet = db.Set<T>().Find(id);
            if (dataToGet == null)
            {
                throw new System.Exception("There is no such id that you are searching for");
            }
            
            return dataToGet;
        }

        public bool Update(T entity)
        {
            return true;
        }
    }
}
