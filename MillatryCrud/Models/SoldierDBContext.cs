using Microsoft.EntityFrameworkCore;

namespace MillatryCrud.Models
{
    public class SoldierDBContext : DbContext
    {
        public SoldierDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Soldier>Soldiers { get; set; }
    }
}
