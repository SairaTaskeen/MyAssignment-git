using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class Staff
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public DateTime JoiningDate { get; set; }
        /// <summary>
        /// ///////////
        /// </summary>

        public ICollection<Doctor> Doctor { get; set; }

        public ICollection<DeskStaff> DeskStaff { get; set; }
        [ForeignKey("ClinicId")]
        public int ClinicId { get; set; }
        public Clinic Clinic { get; set; }
    }
}
