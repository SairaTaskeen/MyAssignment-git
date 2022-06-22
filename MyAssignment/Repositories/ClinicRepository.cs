using Microsoft.EntityFrameworkCore;
using MyAssignment.Models;

using System.Collections.Generic;

using System.Linq;

namespace MyAssignment.Repositories
{
    public class ClinicRepository : BaseRepository<Clinic>, IRepository<Clinic>
    {
        public ClinicRepository(MyDbContext Clinicdb) : base(Clinicdb)
        {
        }
       /* public override ICollection<Clinic> Get()
        {
            var data = db.Clinic
            .Include(Clinic => Clinic.Name)
            .Include(Clinic => Clinic.Staff)
            .ToList();
            return data;
        }
       */



    }

}



