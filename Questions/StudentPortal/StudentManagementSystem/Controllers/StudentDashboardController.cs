using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Helpers;
using StudentManagementSystem.ViewModels;

namespace StudentManagementSystem.Controllers;

public class StudentDashboardController : Controller
{
    private readonly ApplicationDbContext _context;

    public StudentDashboardController(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        if (!HttpContext.IsLoggedIn() || !HttpContext.IsStudent())
        {
            return RedirectToAction("Login", "Account");
        }

        var email = HttpContext.Session.GetString("Email");
        var student = await _context.Students
            .Include(s => s.Department)
            .Include(s => s.Course)
            .ThenInclude(c => c!.Department)
            .FirstOrDefaultAsync(s => s.Email == email);

        if (student == null)
        {
            return RedirectToAction(nameof(Profile));
        }

        var vm = new StudentProfileViewModel
        {
            StudentId = student.StudentId,
            StudentName = student.StudentName,
            Email = student.Email,
            PhoneNumber = student.PhoneNumber,
            Address = student.Address,
            DepartmentName = student.Department?.DepartmentName ?? "Not Assigned",
            CourseName = student.Course?.CourseName ?? "Not Assigned",
            CourseDuration = student.Course?.Duration ?? "-",
            CourseFees = student.Course?.Fees ?? 0
        };

        return View(vm);
    }

    [HttpGet]
    public async Task<IActionResult> Profile()
    {
        if (!HttpContext.IsLoggedIn() || !HttpContext.IsStudent())
        {
            return RedirectToAction("Login", "Account");
        }

        var email = HttpContext.Session.GetString("Email");
        var student = await _context.Students
            .Include(s => s.Department)
            .Include(s => s.Course)
            .FirstOrDefaultAsync(s => s.Email == email);

        if (student == null)
        {
            return NotFound("Student profile not found.");
        }

        var vm = new StudentProfileViewModel
        {
            StudentId = student.StudentId,
            StudentName = student.StudentName,
            Email = student.Email,
            PhoneNumber = student.PhoneNumber,
            Address = student.Address,
            DepartmentName = student.Department?.DepartmentName ?? "Not Assigned",
            CourseName = student.Course?.CourseName ?? "Not Assigned",
            CourseDuration = student.Course?.Duration ?? "-",
            CourseFees = student.Course?.Fees ?? 0
        };

        return View(vm);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Profile(StudentProfileViewModel model)
    {
        if (!HttpContext.IsLoggedIn() || !HttpContext.IsStudent())
        {
            return RedirectToAction("Login", "Account");
        }

        var email = HttpContext.Session.GetString("Email");
        var student = await _context.Students
            .Include(s => s.Department)
            .Include(s => s.Course)
            .FirstOrDefaultAsync(s => s.Email == email);

        if (student == null)
        {
            return NotFound("Student profile not found.");
        }

        if (!ModelState.IsValid)
        {
            model.StudentName = student.StudentName;
            model.Email = student.Email;
            model.DepartmentName = student.Department?.DepartmentName ?? "Not Assigned";
            model.CourseName = student.Course?.CourseName ?? "Not Assigned";
            model.CourseDuration = student.Course?.Duration ?? "-";
            model.CourseFees = student.Course?.Fees ?? 0;
            return View(model);
        }

        student.PhoneNumber = model.PhoneNumber;
        student.Address = model.Address;
        await _context.SaveChangesAsync();

        TempData["Success"] = "Profile updated successfully.";
        return RedirectToAction(nameof(Profile));
    }
}
