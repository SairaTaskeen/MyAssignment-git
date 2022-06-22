using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class PersonService : BaseService<Person>, IService<Person>
    {
        public PersonService(IRepository<Person> Repo) : base(Repo)
        {
        }
    }
}
