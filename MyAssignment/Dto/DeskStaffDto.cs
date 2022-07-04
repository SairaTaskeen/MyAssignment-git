using MyAssignment.Models;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.DbModels
{
    public class DeskStaffDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Qualification { get; set; }
        public string ShiftTiming { get; set; }
        public DateTime DutyTime {  get; set; }
        public int StaffId { get; set; }
        public StaffDto Staff { get; set; }
    }
}
