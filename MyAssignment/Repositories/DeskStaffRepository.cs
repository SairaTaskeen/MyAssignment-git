using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class DeskStaffRepository : BaseRepository<DeskStaff>, IRepository<DeskStaff>
    {
        public DeskStaffRepository(MyDbContext DeskStaffdb) : base(DeskStaffdb)
        {
        }
    }
}
