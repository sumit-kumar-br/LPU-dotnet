using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.ViewModels;

public class StudentProfileViewModel
{
    public int StudentId { get; set; }

    [Display(Name = "Name")]
    public string StudentName { get; set; } = string.Empty;

    public string Email { get; set; } = string.Empty;

    [Phone]
    [Display(Name = "Phone Number")]
    public string? PhoneNumber { get; set; }

    [Display(Name = "Address")]
    public string? Address { get; set; }

    [Display(Name = "Department")]
    public string DepartmentName { get; set; } = string.Empty;

    [Display(Name = "Course")]
    public string CourseName { get; set; } = string.Empty;

    public string CourseDuration { get; set; } = string.Empty;

    public decimal CourseFees { get; set; }
}
