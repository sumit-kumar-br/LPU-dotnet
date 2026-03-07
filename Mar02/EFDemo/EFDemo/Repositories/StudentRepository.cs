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
        public async Task<List<Student>> GetAllAsync(string q = null)
        {
            var query = _db.Students.AsQueryable();

            if (!string.IsNullOrWhiteSpace(q))
            {
                q = q.Trim().ToLower();
                query = query.Where(s =>
                    s.FullName.ToLower().Contains(q) ||
                    s.Email.ToLower().Contains(q));
            }

            return await query
                .AsNoTracking()
                .OrderByDescending(s => s.CreatedAt)
                .ToListAsync();
        }
        public async Task<Student?> GetByIdAsync(int id)
        {
            return await _db.Students.FirstOrDefaultAsync(m=>m.StudentId == id);
        }
        public async Task AddAsync(Student student)
        {
            _db.Add(student);
            await _db.SaveChangesAsync();

        }
        public async Task UpdateAsync(Student student)
        {
            _db.Update(student);
            await _db.SaveChangesAsync();
        }
        public async Task DeleteAsync(int id)
        {
            var student = await _db.Students.FindAsync(id);
            if(student != null)
            {
                _db.Students.Remove(student);
                await _db.SaveChangesAsync();
            }
        }
        public Task<bool> StudentExistsAsync(int id)
        {
            return _db.Students.AnyAsync(m=>m.StudentId==id);
        }

    }
}
