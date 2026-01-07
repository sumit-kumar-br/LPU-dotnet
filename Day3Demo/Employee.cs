using System;

namespace Day3Demo;

internal class Employee: Person
{
    string Skill;
    string desig;
    int empId;
    int bSal;

    public Employee()
    {
        System.Console.WriteLine("Employee Class Constructor invoked");
    }
    ~Employee()
    {
        System.Console.WriteLine("Employee Class Destructor invoked");
    }
}
