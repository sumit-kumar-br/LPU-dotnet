using Microsoft.EntityFrameworkCore;
using LibraryBookManagementSystem.Models;

namespace LibraryBookManagementSystem.Data
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}