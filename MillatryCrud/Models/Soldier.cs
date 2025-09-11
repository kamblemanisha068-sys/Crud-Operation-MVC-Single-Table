using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MillatryCrud.Models
{
    public class Soldier
    {
        [Key]
        [DisplayName("ID")]
        public int ID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Soldier_Name { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Rank")]
        public string Rank { get; set; }
        [Required]
        [DisplayName("Service Number")]
        public int Service_Number { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Branch")]
        public string Branch { get; set; }
        [Required]
        [DisplayName("Age")]
        public int Soldier_Age { get; set; }
        [Required]
        [MaxLength (100)]
        [DisplayName("Nationality")]
        public string Nationality { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Blood Group")]
        public string Blood_Group { get; set; }
    }
}
