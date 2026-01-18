using System;
using System.Collections.Generic;

class CalculateNumbers
{
    List<double> numbers = new List<double>();

    public void AddNumbers(int number)
    {
        numbers.Add(number);
    }

    public double GetGpaScore()
    {
        return numbers.Sum() / numbers.Count;
    }

    public char GetGrade(double gpa)
    {
        if (gpa >= 10) return 'S';
        if (gpa >= 9) return 'A';
        if (gpa >= 8) return 'B';
        if (gpa >= 7) return 'C';
        if (gpa >= 6) return 'D';
        return 'E';
    }
    static void Main()
    {
        CalculateNumbers calc = new CalculateNumbers();

        Console.WriteLine("Enter number of subjects:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter mark:");
            calc.AddNumbers(int.Parse(Console.ReadLine()));
        }

        double gpa = calc.GetGpaScore();
        Console.WriteLine("GPA: " + gpa);
        Console.WriteLine("Grade: " + calc.GetGrade(gpa));
    }
}
