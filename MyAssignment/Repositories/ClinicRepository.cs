using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class ClinicRepository : BaseRepository<Clinic>, IRepository<Clinic>
    {
        public ClinicRepository(MyDbContext db) : base(db)
        {
        }
    }
}
