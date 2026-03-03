using Microsoft.EntityFrameworkCore;

namespace EFCoreMVCWebDemo.Models
{
    public class LPUTrialDbDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder opBldr)
        {
            opBldr.UseSqlServer("server=localhost\\sqlexpress;Trusted_Connection=True;Database=LPUTrial;TrustServerCertificate=true");
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
