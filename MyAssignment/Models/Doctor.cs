using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class Doctor
    {
       [Key]
        public int Id { get; set; }
        [Required]
        public string name { get; set; }
        public int age { get; set; }
        [Required]
        public int phoneNumber { get; set; }
        public string Qualification { get; set; }
     
       [ForeignKey("StaffId")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        
        public ICollection<Visit> Visits { get; set; }

    }
}
