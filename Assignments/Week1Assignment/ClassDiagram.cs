// Assignment 4

using System;

namespace Week1Assignment;

public class MedicalAid
{
    public int MedicalAidNumber { get; set; }
    public int DependentContribution { get; set; }
    public int EmployeeContribution { get; set; }
    public int CompanyContribution { get; set; }
}

public class Pension
{
    public int PensionNumber { get; set; }
    public string Beneficiaries { get; set; }
    public double Amount { get; set; }
    public string DateOfRetirement { get; set; }
}
public class Employee
{
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public int Earnings { get; set; }
    public int EmpNumber { get; set; }
    public MedicalAid MedicalAid { get; set; }
    
}
public class Manager : Employee
{
    public double FixedSalary { get; set; }
    public double CalculateSalary()
    {
        double finalSalary = FixedSalary;
        return finalSalary;
    }
}
public class CommissionWorker : Employee
{
    public double FlatSalary { get; set; }
    public double SalesPercent { get; set; }
    public int SalesMade { get; set; }
    public double CalculateSalary()
    {
        double finalSalary = FlatSalary + (SalesMade*SalesPercent)/100;
        return finalSalary;
    }
}
public class HourlyWorker : Employee
{
    public int HoursWorked { get; set; }
    public double WagePerHour { get; set; }
    public double CalculateSalary()
    {
        double finalSalary = HoursWorked*WagePerHour;
        return finalSalary;
    }
}

