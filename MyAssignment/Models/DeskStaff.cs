using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class DeskStaff
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string ShiftTiming { get; set; }
        public DateTime DuetyTime { get; set; }
        /// <summary>
        /// ///
        /// </summary>
        [ForeignKey("StaffId")]
        public int StaffId { get; set; }
        public Staff Staff { get; set; }
    }
}
