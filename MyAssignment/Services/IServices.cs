using System.Collections.Generic;

namespace MyAssignment.Services
{
    public interface IService<T>
    {

        bool Add(T obj);
        bool Update(T obj);
        ICollection<T> Get();
        T Get(int id);
        bool Delete(int id);

    }
}
