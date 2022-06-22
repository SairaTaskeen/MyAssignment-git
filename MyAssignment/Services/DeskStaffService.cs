using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class DeskStaffService : BaseService<DeskStaff>, IService<DeskStaff>
    {
        public DeskStaffService(IRepository<DeskStaff> Repo) : base(Repo)
        {
        }
    }
}
