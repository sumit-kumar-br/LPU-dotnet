using System;

namespace Week1Assignment;

public class Employee
{
    public string firstName { get; set; }
    public string surname { get; set; }
    public int earnings { get; set; }
    public int empNumber { get; set; }
}
public class Manager : Employee
{
    public double FixedSalary { get; set; }
}
public class CommissionWorker : Employee
{
    public double FlatSalary { get; set; }
    public int SalesPercent { get; set; }
    public int SalesMade { get; set; }
}
public class HourlyWorker : Employee
{
    public int HoursWorked { get; set; }
    public double WagePerHour { get; set; }
}

