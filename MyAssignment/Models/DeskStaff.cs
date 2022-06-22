using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class DeskStaff
    {

       [Key]
        public int Id { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string ShiftTiming { get; set; }
        [Required]
        public DateTime DutyTime { get; set; }
      
       [ForeignKey("StaffId")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
