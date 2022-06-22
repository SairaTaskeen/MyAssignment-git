using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class VisitService : BaseService<Visit>, IService<Visit>
    {
        public VisitService(IRepository<Visit> Repo) : base(Repo)
        {
        }
    }
}
