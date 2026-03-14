using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers;

public class CourseController : Controller
{
    private readonly ApplicationDbContext _context;

    public CourseController(ApplicationDbContext context)
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

    public async Task<IActionResult> Index()
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        var courses = await _context.Courses
            .Include(c => c.Department)
            .OrderBy(c => c.CourseName)
            .ToListAsync();
        return View(courses);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        LoadDepartments();
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Course course)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        if (!ModelState.IsValid)
        {
            LoadDepartments(course.DepartmentId);
            return View(course);
        }

        _context.Courses.Add(course);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Course created successfully.";
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

        var course = await _context.Courses.FindAsync(id);
        if (course == null)
        {
            return NotFound();
        }

        LoadDepartments(course.DepartmentId);
        return View(course);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Course course)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        if (!ModelState.IsValid)
        {
            LoadDepartments(course.DepartmentId);
            return View(course);
        }

        _context.Courses.Update(course);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Course updated successfully.";
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

        var course = await _context.Courses
            .Include(c => c.Department)
            .FirstOrDefaultAsync(c => c.CourseId == id);

        if (course == null)
        {
            return NotFound();
        }

        return View(course);
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

        var course = await _context.Courses
            .Include(c => c.Students)
            .FirstOrDefaultAsync(c => c.CourseId == id);

        if (course == null)
        {
            return NotFound();
        }

        if (course.Students.Any())
        {
            TempData["Error"] = "Cannot delete a course with assigned students.";
            return RedirectToAction(nameof(Index));
        }

        _context.Courses.Remove(course);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Course deleted successfully.";
        return RedirectToAction(nameof(Index));
    }

    private void LoadDepartments(int? selectedDepartmentId = null)
    {
        ViewBag.Departments = new SelectList(_context.Departments.OrderBy(d => d.DepartmentName), "DepartmentId", "DepartmentName", selectedDepartmentId);
    }
}
