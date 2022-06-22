using Microsoft.EntityFrameworkCore;
using MyAssignment.Models;


namespace MyAssignment
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
          
                .UseSqlServer(@"Data Source=CRIBL-TASKESAI1\MSSQLSERVER01;Initial Catalog=ClinicData;Integrated Security=True;");
        public DbSet<Clinic> Clinic { get; set; }
        public DbSet<Person> Person { get; set; }
        public DbSet<DeskStaff>DeskStaff { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Visit> Visit { get; set; }

    }
}
