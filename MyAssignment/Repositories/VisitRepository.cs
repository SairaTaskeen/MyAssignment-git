using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class VisitRepository : BaseRepository<Visit>, IRepository<Visit>
    {
        public VisitRepository(MyDbContext Visitdb) : base(Visitdb)
        {
        }
    }
}
