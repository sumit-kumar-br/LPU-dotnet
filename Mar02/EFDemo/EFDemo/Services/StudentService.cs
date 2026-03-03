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
    }
}
