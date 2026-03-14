using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models;

public class Department
{
    public int DepartmentId { get; set; }

    [Required]
    [StringLength(100)]
    public string DepartmentName { get; set; } = string.Empty;

    [StringLength(250)]
    public string? Description { get; set; }

    public ICollection<Course> Courses { get; set; } = new List<Course>();
    public ICollection<Student> Students { get; set; } = new List<Student>();
}
