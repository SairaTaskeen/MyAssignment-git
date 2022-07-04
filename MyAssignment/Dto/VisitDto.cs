using MyAssignment.Models;
using System.Collections.Generic;

namespace MyAssignment.DbModels
{
    public class VisitDto
    {
        public int Id { get; set; }

        ICollection<DoctorDto> Doctors { get; set; }
        ICollection<PatientDto> Patients { get; set; }
    }
}
