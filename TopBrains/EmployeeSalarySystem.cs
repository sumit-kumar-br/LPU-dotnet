public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; }
    public double Salary { get; set; }
}

public class AnalyticsEngine
{
    public void filterHighSalaryEmployee(List<Employee> employees)
    {
        List<Employee> highSalaryEmployees = employees.Where(s => s.Salary >= 50000).ToList();
        Console.WriteLine("High Salary Employees:");
        highSalaryEmployees.ForEach(s => Console.WriteLine(s.Name));
        Console.WriteLine();
    }

    public void sortEmployeesBySalary(List<Employee> employees)
    {
        List<Employee> sortedEmployees = employees.OrderByDescending(s => s.Salary).ToList();
        Console.WriteLine("Employees Sorted by Salary:");
        sortedEmployees.ForEach(s => Console.WriteLine($"{s.Name} - {s.Salary}"));
        Console.WriteLine();
    }

    public void calculateAverageSalary(List<Employee> employees)
    {
        double averageSalary = employees.Average(s => s.Salary);
        Console.WriteLine("Average Salary:");
        Console.WriteLine($"Rs {averageSalary}");
        Console.WriteLine();
    }
}
public class Solution
{
    public static void Main()
    {
        List<Employee> employeesList = new List<Employee>()
        {
            new Employee{EmployeeId = 301, Name = "Ramesh", Salary = 45000},
            new Employee{EmployeeId = 302, Name = "Suresh", Salary = 52000},
            new Employee{EmployeeId = 303, Name = "Kavya", Salary = 68000},
            new Employee{EmployeeId = 304, Name = "Anita", Salary = 39000},
        };
        AnalyticsEngine engine = new AnalyticsEngine();
        engine.filterHighSalaryEmployee(employeesList);
        engine.sortEmployeesBySalary(employeesList);
        engine.calculateAverageSalary(employeesList);
    }
}