using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class DoctorRepository : BaseRepository<Doctor>, IRepository<Doctor>
    {
        public DoctorRepository(MyDbContext Doctordb) : base(Doctordb)
        {
        }
    }
}
