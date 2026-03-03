using EFDemo.Models;
using Microsoft.EntityFrameworkCore;

namespace EFDemo.Repositories
{
    public class StudentRepository: IStudentRepository
    {
        private readonly StudentPortalDbContext _db;
        public StudentRepository(StudentPortalDbContext db)
        {
            _db = db;
        }
        public async Task<List<Student>> GetAllAsync(string p = null)
        {
            var query = _db.Students.AsQueryable();

            if (!string.IsNullOrEmpty(p))
            {
                query = query.Where(s => s.FullName.Contains(p));
            }
            return await query.ToListAsync();
        }
    }
}
