using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers;

public class StudentController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentController(ApplicationDbContext context)
    {
        _context = context;
    }

    private IActionResult? AuthorizeTeacher()
    {
        if (!HttpContext.IsLoggedIn() || !HttpContext.IsTeacher())
        {
            return RedirectToAction("Login", "Account");
        }

        return null;
    }

    public async Task<IActionResult> Index(string? searchName, int? departmentId)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        var query = _context.Students
            .Include(s => s.Department)
            .Include(s => s.Course)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(searchName))
        {
            query = query.Where(s => s.StudentName.Contains(searchName));
        }

        if (departmentId.HasValue && departmentId.Value > 0)
        {
            query = query.Where(s => s.DepartmentId == departmentId.Value);
        }

        ViewBag.SearchName = searchName;
        ViewBag.DepartmentId = departmentId;
        ViewBag.Departments = new SelectList(_context.Departments.OrderBy(d => d.DepartmentName), "DepartmentId", "DepartmentName", departmentId);

        var students = await query.OrderBy(s => s.StudentName).ToListAsync();
        return View(students);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        LoadDropdowns();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Student student)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        if (!ModelState.IsValid)
        {
            LoadDropdowns(student.DepartmentId, student.CourseId);
            return View(student);
        }

        _context.Students.Add(student);
        await _context.SaveChangesAsync();

        await EnsureStudentUser(student);

        TempData["Success"] = "Student created successfully.";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return NotFound();
        }

        LoadDropdowns(student.DepartmentId, student.CourseId);
        return View(student);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Student student)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        if (!ModelState.IsValid)
        {
            LoadDropdowns(student.DepartmentId, student.CourseId);
            return View(student);
        }

        _context.Students.Update(student);
        await _context.SaveChangesAsync();

        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == student.Email && u.Role == "Student");
        if (user != null)
        {
            user.FullName = student.StudentName;
            await _context.SaveChangesAsync();
        }

        TempData["Success"] = "Student updated successfully.";
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        var student = await _context.Students
            .Include(s => s.Department)
            .Include(s => s.Course)
            .FirstOrDefaultAsync(s => s.StudentId == id);

        if (student == null)
        {
            return NotFound();
        }

        return View(student);
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        var student = await _context.Students.FindAsync(id);
        if (student == null)
        {
            return NotFound();
        }

        _context.Students.Remove(student);
        await _context.SaveChangesAsync();

        TempData["Success"] = "Student deleted successfully.";
        return RedirectToAction(nameof(Index));
    }

    private void LoadDropdowns(int? selectedDepartmentId = null, int? selectedCourseId = null)
    {
        ViewBag.Departments = new SelectList(_context.Departments.OrderBy(d => d.DepartmentName), "DepartmentId", "DepartmentName", selectedDepartmentId);
        ViewBag.Courses = new SelectList(_context.Courses.OrderBy(c => c.CourseName), "CourseId", "CourseName", selectedCourseId);
    }

    private async Task EnsureStudentUser(Student student)
    {
        var userExists = await _context.Users.AnyAsync(u => u.Email == student.Email);
        if (!userExists)
        {
            _context.Users.Add(new User
            {
                FullName = student.StudentName,
                Email = student.Email,
                Password = "Student@123",
                Role = "Student"
            });
            await _context.SaveChangesAsync();
        }
    }
}
