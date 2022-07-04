using MyAssignment.Models;
using System;
using System.Collections.Generic;

namespace MyAssignment.DbModels
{
    public class StaffDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DutyTiming { get; set; }
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }

        public ICollection<DoctorDto> Doctors { get; set; }

        public ICollection<DeskStaffDto> DeskStaff { get; set; }
    }
}
