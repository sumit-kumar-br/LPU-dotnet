using System;

namespace ListDemo;

class Employee
{
    public int EmpId { get; set; }
    public string EmpName { get; set; }
    public double Salary { get; set; }
}
public class ListDemo
{
    public static void ListDemoFunc()
    {
        List<Employee> EmpList = new List<Employee>()
        {
            new Employee(){EmpId = 101, EmpName = "Sumit", Salary = 10000.0},
        };
    }
}
