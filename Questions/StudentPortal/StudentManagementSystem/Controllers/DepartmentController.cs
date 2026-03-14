using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.Models;

namespace StudentManagementSystem.Controllers;

public class DepartmentController : Controller
{
    private readonly ApplicationDbContext _context;

    public DepartmentController(ApplicationDbContext context)
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

        var departments = await _context.Departments.OrderBy(d => d.DepartmentName).ToListAsync();
        return View(departments);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(Department department)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        if (!ModelState.IsValid)
        {
            return View(department);
        }

        _context.Departments.Add(department);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Department created successfully.";
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

        var department = await _context.Departments.FindAsync(id);
        if (department == null)
        {
            return NotFound();
        }

        return View(department);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(Department department)
    {
        var auth = AuthorizeTeacher();
        if (auth != null)
        {
            return auth;
        }

        if (!ModelState.IsValid)
        {
            return View(department);
        }

        _context.Departments.Update(department);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Department updated successfully.";
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

        var department = await _context.Departments.FindAsync(id);
        if (department == null)
        {
            return NotFound();
        }

        return View(department);
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

        var department = await _context.Departments
            .Include(d => d.Courses)
            .Include(d => d.Students)
            .FirstOrDefaultAsync(d => d.DepartmentId == id);

        if (department == null)
        {
            return NotFound();
        }

        if (department.Courses.Any() || department.Students.Any())
        {
            TempData["Error"] = "Cannot delete a department that has courses or students.";
            return RedirectToAction(nameof(Index));
        }

        _context.Departments.Remove(department);
        await _context.SaveChangesAsync();
        TempData["Success"] = "Department deleted successfully.";
        return RedirectToAction(nameof(Index));
    }
}
