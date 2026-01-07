using System;
using System.Dynamic;

namespace Day4OOPDemo;

public class Manager: Employee
{
    public int Incentive { get; set; }
    public override int CalculateSalary(int sal)
    {
        int mySal = 0;
        // NetSalary=Salary + HRA + TA + DA - PF
        mySal = (sal + 25000 + 5000 + 3500 - 4500);
        return mySal;
    }


}
