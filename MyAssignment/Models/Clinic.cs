using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MyAssignment.Models
{
    public class Clinic
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
       public ICollection<Person> Person { get; set; }
        

    }
}
