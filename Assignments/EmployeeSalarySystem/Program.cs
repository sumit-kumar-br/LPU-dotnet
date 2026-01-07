// See https://aka.ms/new-console-template for more information

using System;

// Console.WriteLine("Hello, World!");


// Step 1: Input Details
int empID;
string empName;
int age;
int deptChoice;
double salary;
Console.WriteLine("Enter the employee ID: ");
empID = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the employee name: ");
empName = Console.ReadLine();
Console.WriteLine("Enter the employee age: ");
age = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the department choice: ");
deptChoice = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the employee salary: ");
salary = double.Parse(Console.ReadLine());


// Step 2: Age Validation
if (age < 21)
{
    Console.WriteLine("Employee is not eligible to work");
    return;
}


// Step 3: Department & Role Selection (Nested Switch)
string dept;
int role;
int allowancePercentage;
switch (deptChoice)
{
    case 1:
        dept = "IT";
        Console.WriteLine("Enter role: ");
        Console.WriteLine("1. Developer");
        Console.WriteLine("2. Tester");
        role = Int32.Parse(Console.ReadLine());
        switch (role)
        {
            case 1:
                allowancePercentage = 30;
                break;
            case 2:
                allowancePercentage = 25;
                break;
            default:
                Console.WriteLine("Invalid role");
                return;
        }
        break;
    case 2:
        dept = "HR";
        Console.WriteLine("Enter role: ");
        Console.WriteLine("1. Recruiter");
        Console.WriteLine("2. Payroll");
        role = Int32.Parse(Console.ReadLine());
        switch (role)
        {
            case 1:
                allowancePercentage = 20;
                break;
            case 2:
                allowancePercentage = 22;
                break;
            default:
                Console.WriteLine("Invalid role");
                return;
        }
        break;
    case 3:
        dept = "Finance";
        Console.WriteLine("Enter role");
        Console.WriteLine("1. Accountant");
        Console.WriteLine("2. Auditor");
        role = Int32.Parse(Console.ReadLine());
        switch (role)
        {
            case 1:
                allowancePercentage = 28;
                break;
            case 2:
                allowancePercentage = 26;
                break;
            default:
                Console.WriteLine("Invalid role");
                return;
        }
        break;
    default:
        Console.WriteLine("Invalid Department");
        return;
}


// Step 4: Salary Calculation
double finalSalary;
finalSalary = salary + (allowancePercentage * salary / 100);


// Step 5: Access Level Decision
string accessLevel;
if (finalSalary >= 60000)
{
    if (dept == "IT")
    {
        accessLevel = "Admin";
    }
    else
    {
        accessLevel = "Manager";
    }
}
else
{
    accessLevel = "Employee";
}


// Step 6: Output
Console.WriteLine($"Employee ID: {empID}");
Console.WriteLine($"Employee Name: {empName}");
Console.WriteLine($"Department: {dept}");
Console.WriteLine($"Role: {role}");
Console.WriteLine($"Basic Salary: {salary}");
Console.WriteLine($"Final Salary: {finalSalary}");
Console.WriteLine($"Access Level: {accessLevel}");


