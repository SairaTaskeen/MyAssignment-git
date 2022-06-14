using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class Patient
    {
        [Key]
        public int Id { get; set; }


        public string Name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public int PhoneNo { get; set; }
        public string disease { get; set; }
        public string prescriptions { get; set; }
        public string Allergies { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [ForeignKey("ClinicId")]
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
        ICollection<Visit> Visit { get; set; }
    }
}
