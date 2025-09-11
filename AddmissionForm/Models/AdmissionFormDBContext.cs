using Microsoft.EntityFrameworkCore;

namespace AddmissionForm.Models
{
    public class AdmissionFormDBContext : DbContext
    {
        public AdmissionFormDBContext(DbContextOptions options) : base(options)

        {
            
        }
        public DbSet<AdmissionForm> AdmissionForms { get; set; }
    }
}
