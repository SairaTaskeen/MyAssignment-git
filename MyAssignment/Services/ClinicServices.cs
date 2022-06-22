using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class ClinicServices : BaseService<Clinic>, IService<Clinic>
    {
        public ClinicServices(IRepository<Clinic> Repo) : base(Repo)
        {
        }
    }
}
