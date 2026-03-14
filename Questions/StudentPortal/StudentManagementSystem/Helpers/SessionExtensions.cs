namespace StudentManagementSystem.Helpers;

public static class SessionExtensions
{
    public static bool IsLoggedIn(this HttpContext httpContext)
    {
        return httpContext.Session.GetInt32("UserId") != null;
    }

    public static bool IsTeacher(this HttpContext httpContext)
    {
        return string.Equals(httpContext.Session.GetString("Role"), "Teacher", StringComparison.OrdinalIgnoreCase);
    }

    public static bool IsStudent(this HttpContext httpContext)
    {
        return string.Equals(httpContext.Session.GetString("Role"), "Student", StringComparison.OrdinalIgnoreCase);
    }
}
