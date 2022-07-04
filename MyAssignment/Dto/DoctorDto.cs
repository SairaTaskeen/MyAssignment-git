using MyAssignment.Models;
using System.Collections.Generic;


namespace MyAssignment.DbModels
{
    public class DoctorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int phoneNumber { get; set; }
        public string Qualification { get; set; }
        public int StaffId { get; set; }
        public StaffDto Staff { get; set; }
        public int VisitId { get; set; }
        public VisitDto Visit { get; set; }
    }
}
