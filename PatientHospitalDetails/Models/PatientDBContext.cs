using Microsoft.EntityFrameworkCore;

namespace PatientHospitalDetails.Models
{
    public class PatientDBContext : DbContext


    {

        public PatientDBContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Patient> Patients{ get; set; }
    }
}
