using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models;

public class Student
{
    public int StudentId { get; set; }

    [Required]
    [StringLength(100)]
    public string StudentName { get; set; } = string.Empty;

    [Required]
    [EmailAddress]
    [StringLength(150)]
    public string Email { get; set; } = string.Empty;

    [Phone]
    [StringLength(20)]
    public string? PhoneNumber { get; set; }

    [StringLength(250)]
    public string? Address { get; set; }

    [Required]
    public int DepartmentId { get; set; }

    [Required]
    public int CourseId { get; set; }

    public Department? Department { get; set; }
    public Course? Course { get; set; }
}
