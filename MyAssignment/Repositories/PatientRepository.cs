﻿using MyAssignment.Models;

namespace MyAssignment.Repositories
{
    public class PatientRepository : BaseRepository<Patient>, IRepository<Patient>
    {
        public PatientRepository(MyDbContext db) : base(db)
        {
        }
    }
}
