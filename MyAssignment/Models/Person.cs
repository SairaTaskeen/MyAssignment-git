using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class Person
    {
        [Key]
        public int Id { get; set; }

       
        public string email { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string LogInPwd { get; set; }
        public string Name { get; set; }
        [ForeignKey("ClinicId")]
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        public ICollection<Staff> Staff { get; set; }
        public ICollection<Patient> Patients { get; set; }

    }
}
