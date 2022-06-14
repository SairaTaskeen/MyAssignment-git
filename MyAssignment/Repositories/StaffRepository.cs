using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class StaffRepository : BaseRepository<Staff>, IRepository<Staff>
    {
        public StaffRepository(MyDbContext db) : base(db)
        {
        }
    }
}
