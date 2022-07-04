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
        public DateTime DutyTiming { get; set; }

        /// <summary>
        /// ///////////
        /// </summary>
      
        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public ICollection<Doctor> Doctors { get; set; }

       public ICollection<DeskStaff> DeskStaff { get; set; }
       
    }
}
