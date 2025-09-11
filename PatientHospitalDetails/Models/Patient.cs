using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PatientHospitalDetails.Models
{
    public class Patient
    {
        [Key]
        [DisplayName("ID")]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Patient Name")]
        public string Patient_Name { get; set; }
        [Required]
        [DisplayName("Age")]
        public int Age { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [Required]
        [DisplayName("Contact Number")]

        public long Contact_Number { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Address")]

        public string Address { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Symptoms")]
    
        public string Diagnosis { get; set; }
        [Required]
        [DisplayName("Addmission Date")]
        public DateTime AddmissionDate { get; set; }
        [Required]
        [DisplayName("Discharge Date")]
        public DateTime DischargeDate { get; set; }
    }
}
