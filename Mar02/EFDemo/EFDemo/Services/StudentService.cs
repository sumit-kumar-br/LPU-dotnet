using EFDemo.Models;
using EFDemo.Repositories;
namespace EFDemo.Services
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _repo;
        public StudentService(IStudentRepository repo)
        {
            _repo = repo;
        }

        public Task<List<Student>> SearchAsync(string q = null) => _repo.GetAllAsync(q);
        public Task<Student?> GetByIdAsync(int id) => _repo.GetByIdAsync(id);

        public Task AddAsync(Student student) => _repo.AddAsync(student);
        public Task UpdateAsync(Student student) => _repo.UpdateAsync(student);
        public Task DeleteAsync(int id) => _repo.DeleteAsync(id);
        public Task<bool> StudentExistsAsync(int id) => _repo.StudentExistsAsync(id);
    }
}
