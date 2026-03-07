using System;

namespace Day4OOPDemo;

public class Employee
{
    public int BasicSal { get; set; }
    public virtual int CalculateSalary(int sal)
    {
        int mySal = 0;
        // NetSalary=Salary + HRA + TA + DA - PF
        mySal = (sal + 15000 + 3000 + 1500 - 2500); // function shadowing
        return mySal;
    }
}
