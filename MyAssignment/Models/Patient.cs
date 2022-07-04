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
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        [Required(ErrorMessage = "Phone Number Required!")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",
                   ErrorMessage = "Entered phone format is not valid.")]
        public int PhoneNo { get; set; }
        [Required]
        public string disease { get; set; }
        [Required]
        public string prescriptions { get; set; }
        [Required]
        public string Allergies { get; set; }
        [ForeignKey("PersonId")]
        public int PersonId { get; set; }
        public Person Person { get; set; }
        [ForeignKey("VisitId")]
        public int VisitId { get; set; }
        public Visit Visit { get; set; }
    }
}
