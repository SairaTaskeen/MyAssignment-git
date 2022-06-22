using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class PersonRepository : BaseRepository<Person>, IRepository<Person>
    {
        public PersonRepository(MyDbContext db) : base(db)
        {
        }
    }
}
