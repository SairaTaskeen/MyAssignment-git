using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class StaffService : BaseService<Staff>, IService<Staff>
    {
        public StaffService(IRepository<Staff> Repo) : base(Repo)
        {
        }
    }
}
