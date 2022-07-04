using MyAssignment.Models;
using System.Collections.Generic;

namespace MyAssignment.DbModels
{
    public class PersonDto
    {
        public int Id { get; set; }
        public string email { get; set; }
        public string UserName { get; set; }
        public string LogInPwd { get; set; }
        public string Name { get; set; }
        public int ClinicId { get; set; }
        public ClinicDto Clinic { get; set; }
        public ICollection<StaffDto> Staff { get; set; }
        public ICollection<PatientDto> Patients { get; set; }
    }
}
