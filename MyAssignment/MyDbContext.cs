using Microsoft.EntityFrameworkCore;
using MyAssignment.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace MyAssignment
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
        : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AssignmentData");
        }
        public DbSet<Clinic> Clinic { get; set; }
        public DbSet<DeskStaff> Course { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Staff> Staff { get; set; }
        public DbSet<Visit> Visit { get; set; }
    }
}
