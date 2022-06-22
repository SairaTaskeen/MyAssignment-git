using MyAssignment.Models;
using MyAssignment.Repositories;

namespace MyAssignment.Services
{
    public class PatientService : BaseService<Patient>, IService<Patient>
    {
        public PatientService(IRepository<Patient> Repo) : base(Repo)
        {
        }
    }
}
