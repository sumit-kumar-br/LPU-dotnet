using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentManagementSystem.Data;
using StudentManagementSystem.Models;
using StudentManagementSystem.ViewModels;

namespace StudentManagementSystem.Controllers;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register(RegisterViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var existingUser = await _context.Users.AnyAsync(u => u.Email == model.Email.Trim());
        if (existingUser)
        {
            ModelState.AddModelError(nameof(model.Email), "Email is already registered.");
            return View(model);
        }

        var user = new User
        {
            FullName = model.FullName.Trim(),
            Email = model.Email.Trim(),
            Password = model.Password,
            Role = model.Role
        };

        _context.Users.Add(user);

        if (string.Equals(model.Role, "Student", StringComparison.OrdinalIgnoreCase))
        {
            _context.Students.Add(new Student
            {
                StudentName = model.FullName.Trim(),
                Email = model.Email.Trim(),
                PhoneNumber = string.Empty,
                Address = string.Empty,
                DepartmentId = _context.Departments.Select(d => d.DepartmentId).FirstOrDefault(),
                CourseId = _context.Courses.Select(c => c.CourseId).FirstOrDefault()
            });
        }

        await _context.SaveChangesAsync();
        TempData["Success"] = "Registration successful. Please login.";
        return RedirectToAction(nameof(Login));
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Login(LoginViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        var email = model.Email.Trim();
        var user = await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == model.Password);
        if (user == null)
        {
            ViewBag.Error = "Invalid email or password.";
            return View(model);
        }

        HttpContext.Session.SetInt32("UserId", user.UserId);
        HttpContext.Session.SetString("UserName", user.FullName);
        HttpContext.Session.SetString("Role", user.Role);
        HttpContext.Session.SetString("Email", user.Email);

        if (string.Equals(user.Role, "Teacher", StringComparison.OrdinalIgnoreCase))
        {
            return RedirectToAction("Index", "TeacherDashboard");
        }

        return RedirectToAction("Index", "StudentDashboard");
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction(nameof(Login));
    }
}
