using EFDemo.Models;

namespace EFDemo.Services
{
    public interface IStudentService
    {
        Task<List<Student>> SearchAsync(string q = null);
        Task<Student?> GetByIdAsync(int id);
        Task AddAsync(Student student);
        Task UpdateAsync(Student student);
        Task DeleteAsync(int id);
        Task<bool> StudentExistsAsync(int id);
    }
}
