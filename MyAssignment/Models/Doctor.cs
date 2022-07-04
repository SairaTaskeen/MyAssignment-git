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
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        public int phoneNumber { get; set; }
        public string Qualification { get; set; }
     
       [ForeignKey("StaffId")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
        [ForeignKey("VisitId")]
        public int VisitId { get; set; }
        public Visit Visit { get; set; }
    }
}
