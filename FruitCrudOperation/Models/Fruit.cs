using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FruitCrudOperation.Models
{
    public class Fruit
    {
        [Key]
        [DisplayName("ID")]
        public int ID { get; set; }
        [Required]
        [MaxLength(200)]
        [DisplayName("Fruit Name")]
           
        public string FruitName { get; set; }
        [Required]
        [DisplayName("Quantity In Kg")]
        public int Quantity_In_Kg { get; set; }
        [Required]
        [DisplayName("Price In Kg")]
        public int Price_Per_Kg { get; set; }
    }
}
