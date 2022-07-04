using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
     
        ICollection<Doctor> Doctors { get; set; }
        ICollection<Patient> Patients { get; set; }

    }
}
