using System.Collections.Generic;

namespace MyAssignment.Models
{
    public class Clinic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<Staff> Staff { get; set; }
        public ICollection<Patient> Patient { get; set; }
    }
}
