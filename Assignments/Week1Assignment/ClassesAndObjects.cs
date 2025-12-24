using System;
using System.Data;

namespace Week1Assignment;

public class Employee1
{
    private string empDept;
    public string EmpDept
    {
        get=>empDept;
        set
        {
            if(value == null)
            {
                Console.WriteLine("Invalid Dept");
            }
            else
            {
                string[] allowed = {"C2", "TTG", "ITES", "PES"};
                bool isAllowed = false;
                for(int i=0; i<allowed.Length; i++)
                {
                    if(string.Equals(value, allowed[i], StringComparison.OrdinalIgnoreCase))
                    {
                        isAllowed = true;
                        break;
                    }
                }
                if (!isAllowed)
                {
                    Console.WriteLine("Invalid Dept");
                }
                else
                {
                    empDept=value;
                }
            }
        }
    }
    private string empDesig;
    public string EmpDesig {
        get=>empDesig;
        set
        {
            if(value == null)
            {
                Console.WriteLine("Invalid designation");
            }
            else
            {
                string[] allowed = {"developer", "tester", "Lead", "manager"};
                bool isAllowed = false;
                for(int i=0; i<allowed.Length; i++)
                {
                    if(string.Equals(value, allowed[i], StringComparison.OrdinalIgnoreCase))
                    {
                        isAllowed = true;
                        break;
                    }
                }
                if (!isAllowed)
                {
                    Console.WriteLine("Invalid designation");
                }
                else
                {
                    empDesig = value;
                }
            }
        }
    }
    public int EmpId { get; set; }
    private string empName;
    public string EmpName 
    {
        get=>empName;
        set
        {
            if(value == null)
            {
                Console.WriteLine("Invalid designation");
                return;
            }
            else
            {
                empName = value;
            }

        }
    }

}
public class ClassesAndObjects
{

}
