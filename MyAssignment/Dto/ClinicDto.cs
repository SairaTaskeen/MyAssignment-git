using MyAssignment.Models;
using System.Collections.Generic;

namespace MyAssignment.DbModels
{
    public class ClinicDto
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public ICollection<PersonDto> Person { get; set; }
    }
}
    