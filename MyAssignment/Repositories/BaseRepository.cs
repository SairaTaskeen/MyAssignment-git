using System.Collections.Generic;
using System.Linq;

namespace MyAssignment.Repositories
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        protected MyDbContext db;
        public BaseRepository(MyDbContext db)
        {
            this.db = db;
        }
        public bool Add(T entity)
        {
            db.Set<T>().Add(entity);
            db.SaveChanges();
            return true;
        }

        public bool Delete(int id)
        {
            var itemToRemove =this.Get(id);
            db.Set<T>().Remove(itemToRemove);
            return true;
        }

        public ICollection<T> Get()
        {
            var data = db.Set<T>().ToList();
            return data;
        }

        public T Get(int id)
        {
            var dataToGet = db.Set<T>().Find(id);
            return dataToGet;
        }

        public T Search(int id)
        {
            var dataToGet = db.Set<T>().Find(id);
            return dataToGet;
        }

        public bool Update(T entity)
        {
            return true;
        }
    }
}
