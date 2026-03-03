
using Microsoft.EntityFrameworkCore;
using EFDemo.Models;

namespace EFDemo.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync(string q = null);
    }
}
