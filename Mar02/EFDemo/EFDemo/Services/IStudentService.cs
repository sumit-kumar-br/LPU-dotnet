using EFDemo.Models;

namespace EFDemo.Services
{
    public interface IStudentService
    {
        Task<List<Student>> SearchAsync(string q = null);
    }
}
