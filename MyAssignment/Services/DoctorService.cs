using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class DoctorService : BaseService<Doctor>, IService<Doctor>
    {
        public DoctorService(IRepository<Doctor> Repo) : base(Repo)
        {
        }
    }
}
