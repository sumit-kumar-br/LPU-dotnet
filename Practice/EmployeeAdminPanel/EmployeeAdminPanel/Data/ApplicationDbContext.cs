using EmployeeAdminPanel.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployeeAdminPanel.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)  
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
