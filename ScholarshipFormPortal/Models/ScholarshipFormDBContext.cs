using Microsoft.EntityFrameworkCore;

namespace ScholarshipFormPortal.Models
{
    public class ScholarshipFormDBContext : DbContext
    {
        public ScholarshipFormDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<ScholarshipForm> ScholarshipForms { get; set; }
    }
}
