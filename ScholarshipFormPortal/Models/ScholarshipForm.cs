using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ScholarshipFormPortal.Models
{
    public class ScholarshipForm
    {
        [Key]
        [DisplayName("ID")]
        public int Applicant_ID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Applicant Name")]
        public string Applicant_Name { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("College Name")]
        public string College_Name { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Course")]
        public string Course { get; set; }
        [Required]
        [DisplayName("Applied Date")]
        public DateTime AppliedDate { get; set; }
        [Required]
        [DisplayName("Scholarship Amount")]
        public long Scholarship_Amount { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Category")]
        public string Category { get; set; }

    }
}
