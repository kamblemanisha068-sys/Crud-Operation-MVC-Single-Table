using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace VehicleCustomer.Models
{
    public class Customer
    {
        [Key]
        [DisplayName("ID")]
        public int Customer_ID { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Name")]
        public string Customer_Name { get; set; }
        [Required]
        [DisplayName("Age")]
        public string Customer_Age { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Gender")]
        public string Gender { get; set; }
        [Required]
        [MaxLength(100)]
        [DisplayName("Model Name")]
        public string Model_Name { get; set; }
        [Required]
        [DisplayName("Model Price")]
        public int Model_Price { get; set; }
        [Required]
        [DisplayName("Register Date")]
        public DateTime Register_Date { get; set; }
    }
}
