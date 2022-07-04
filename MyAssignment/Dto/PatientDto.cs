using MyAssignment.Models;
using System;
using System.Collections.Generic;

namespace MyAssignment.DbModels
{
    public class PatientDto
    {
      
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
        public DateTime DOB { get; set; }
        public int PhoneNo { get; set; }
        public string Disease { get; set; }
        public string Prescriptions { get; set; }
        public string Allergies { get; set; }
        public int PersonId { get; set; }
        public PersonDto Person { get; set; }
        public int VisitId { get; set; }
        public VisitDto Visit { get; set; }
    }
}
