using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AddmissionForm.Models
{
    public class AdmissionForm
    {
        [Key]
        [DisplayName("ID")]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Student Name")]
        public string Student_Name { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Fathers Name")]
        public string Fathers_Name { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Mothers Name")]
        public string Mothers_Name { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Course Name")]
        public string Course { get; set; }
        [Required]
        [DisplayName("HSC Percentage")]
        public double Percentage_In_HSC { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Previous College Name")]
        public string Previous_College_Name { get; set; }
        [Required]
        [DisplayName("Date Of Birth")]
        public DateTime Date_Of_Birth  { get; set; }
        [Required]
        [DisplayName("Fees")]
        public int Fees { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category")]
        public String Category  { get; set; }

    }
}
