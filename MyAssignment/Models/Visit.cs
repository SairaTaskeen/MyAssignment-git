using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyAssignment.Models
{
    public class Visit
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// /
        /// </summary>
        [ForeignKey("PatientID")]
        public int PatientID { get; set; }
        public Patient Patient { get; set; }
        /// <summary>
        /// /
        /// </summary>
        [ForeignKey("DoctorId")]
        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; }
    }
}
