using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Helpers;

namespace StudentManagementSystem.Controllers;

public class TeacherDashboardController : Controller
{
    private readonly ApplicationDbContext _context;

    public TeacherDashboardController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        if (!HttpContext.IsLoggedIn() || !HttpContext.IsTeacher())
        {
            return RedirectToAction("Login", "Account");
        }

        ViewBag.DepartmentCount = await _context.Departments.CountAsync();
        ViewBag.CourseCount = await _context.Courses.CountAsync();
        ViewBag.StudentCount = await _context.Students.CountAsync();
        ViewBag.StudentsPerDepartment = await _context.Departments
            .Select(d => new
            {
                d.DepartmentName,
                StudentCount = d.Students.Count
            })
            .ToListAsync();

        return View();
    }
}
