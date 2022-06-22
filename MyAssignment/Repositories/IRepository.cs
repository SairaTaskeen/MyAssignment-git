using System.Collections.Generic;

namespace MyAssignment.Repositories
{
    public interface IRepository<T> 
    {
        ICollection<T> Get();
        T Get(int id);
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(int id);
        T Search(int id);
    }
}
