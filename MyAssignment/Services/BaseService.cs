using MyAssignment.Repositories;
using System.Collections.Generic;

namespace MyAssignment.Services
{
    public class BaseService<T> : IService<T>
    {
        protected IRepository<T> Repo;
        public BaseService(IRepository<T> Repo)
        {
            this.Repo = Repo;
        }

        public bool Add(T obj)
        {
           return Repo.Add(obj);
            

        }

        public bool Delete(int id)
        {
            return Repo.Delete(id);
        }

        public ICollection<T> Get()
        {
          return Repo.Get();
            
        }

        public T Get(int id)
        {
            return Repo.Get(id);
        }

        public bool Update(T obj)
        {
            return Repo.Update(obj);
        }
    }
}
