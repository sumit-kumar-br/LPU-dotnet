using System;

namespace Day2PracticeQuestions;

public class GradeDescription
{
    public static void FindGrade()
    {
        char grade;
        Console.WriteLine("Enter the grade");
        grade = Char.Parse(Console.ReadLine());
        switch (grade)
        {
            case 'E': Console.WriteLine("Excellent");
                break;
            case 'V': Console.WriteLine("Very Good");
                break;
            case 'G': Console.WriteLine("Good");
                break;
            case 'A': Console.WriteLine("Average");
                break;
            case 'F': Console.WriteLine("Fail");
                break;
            default: Console.WriteLine("Invalid Grade!!");
                break;
        }
    }
}