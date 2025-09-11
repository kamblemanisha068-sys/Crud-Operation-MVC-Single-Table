using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Studentportal.web.Models
{
    public class Student
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [DisplayName("ID")]
        public int ID{ get; set; }
        [Required]
        [DisplayName("Age")]
        public int Age{ get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Name { get; set; }
        [Required]
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [Required]
        [DisplayName("Mobile")]
        public string Mobile{ get; set; }
        
    }
}
