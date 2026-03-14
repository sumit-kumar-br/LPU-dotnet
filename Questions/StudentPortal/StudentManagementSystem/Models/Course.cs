using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models;

public class Course
{
    public int CourseId { get; set; }

    [Required]
    [StringLength(120)]
    public string CourseName { get; set; } = string.Empty;

    [Required]
    [StringLength(50)]
    public string Duration { get; set; } = string.Empty;

    [Range(0, 1000000)]
    public decimal Fees { get; set; }

    [Required]
    public int DepartmentId { get; set; }

    public Department? Department { get; set; }
    public ICollection<Student> Students { get; set; } = new List<Student>();
}
