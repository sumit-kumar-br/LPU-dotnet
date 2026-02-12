public class Employee
{
    public int EmployeeId { get; set; }
    public string Name { get; set; } = "";
    public double BaseSalary { get; set; }
    public double Bonus { get; set; }
    public double Allowance { get; set; }
    public double Commission { get; set; }
}

public class SalaryEngine
{
    public void Calculate(Employee employee, string department, Func<Employee, double> calculator) 
    {
        Console.WriteLine("========= SALARY CALCULATION =========");
        Console.WriteLine($"Employee Name : {employee.Name}");
        Console.WriteLine($"Department    : {department}");
        Console.WriteLine($"Salary        : {calculator(employee)}");
        Console.WriteLine("------------------------------------");
        Console.WriteLine();

    }
}
public class Solution
{
    public static void Main()
    {
       
        Employee employee = new Employee
        {
            EmployeeId = 601,
            Name = "Ananya",
            BaseSalary = 50000,
            Bonus = 10000,
            Allowance = 8000,
            Commission = 12000
        };
        Func<Employee, double> ITSalaryRule = emp => 
        {
            return emp.BaseSalary + emp.Bonus;
        };
        Func<Employee, double> HRSalaryRule = emp => 
        {
            return emp.BaseSalary + emp.Allowance;
        };
        Func<Employee, double> SalesSalaryRule = emp => 
        {
            return emp.BaseSalary + emp.Commission;
        };
        
        SalaryEngine engine = new SalaryEngine();

        engine.Calculate(employee, "IT", ITSalaryRule);
        engine.Calculate(employee, "HR", HRSalaryRule);
        engine.Calculate(employee, "Sales", SalesSalaryRule);
        
    }
}