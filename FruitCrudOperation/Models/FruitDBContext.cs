using Microsoft.EntityFrameworkCore;

namespace FruitCrudOperation.Models
{
    public class FruitDBContext : DbContext
    {
        public FruitDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Fruit> Fruits { get; set; }
    }
}
