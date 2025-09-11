using Microsoft.EntityFrameworkCore;

namespace VehicleCustomer.Models
{
    public class CustomerDBContext : DbContext
    {
        public CustomerDBContext(DbContextOptions options) : base(options) 
        {
            
        }
        public DbSet<Customer> Customers { get; set; }
    }
}
