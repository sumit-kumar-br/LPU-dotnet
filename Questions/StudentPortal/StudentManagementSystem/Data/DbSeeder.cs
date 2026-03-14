using StudentManagementSystem.Models;

namespace StudentManagementSystem.Data;

public static class DbSeeder
{
    public static void Seed(ApplicationDbContext context)
    {
        if (!context.Users.Any())
        {
            context.Users.AddRange(
                new User
                {
                    FullName = "Teacher Admin",
                    Email = "teacher@portal.com",
                    Password = "Teacher@123",
                    Role = "Teacher"
                },
                new User
                {
                    FullName = "Student Demo",
                    Email = "student@portal.com",
                    Password = "Student@123",
                    Role = "Student"
                });
        }

        if (!context.Departments.Any())
        {
            context.Departments.AddRange(
                new Department { DepartmentName = "Computer Science", Description = "Software and system engineering" },
                new Department { DepartmentName = "Business", Description = "Management and finance studies" });
            context.SaveChanges();
        }

        if (!context.Courses.Any())
        {
            var cs = context.Departments.First(d => d.DepartmentName == "Computer Science");
            var business = context.Departments.First(d => d.DepartmentName == "Business");

            context.Courses.AddRange(
                new Course { CourseName = "ASP.NET Core", Duration = "6 Months", Fees = 25000, DepartmentId = cs.DepartmentId },
                new Course { CourseName = "Business Analytics", Duration = "4 Months", Fees = 18000, DepartmentId = business.DepartmentId });
            context.SaveChanges();
        }

        if (!context.Students.Any())
        {
            var cs = context.Departments.First(d => d.DepartmentName == "Computer Science");
            var asp = context.Courses.First(c => c.CourseName == "ASP.NET Core");

            context.Students.Add(new Student
            {
                StudentName = "Student Demo",
                Email = "student@portal.com",
                PhoneNumber = "9999999999",
                Address = "City Center",
                DepartmentId = cs.DepartmentId,
                CourseId = asp.CourseId
            });
        }

        context.SaveChanges();
    }
}
