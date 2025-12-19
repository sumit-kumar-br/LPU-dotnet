using System;

namespace Day2PracticeQuestions;

public class LeapYearChecker
{
    public static void CheckLeapYear(int year)
    {
        if(year % 400 == 0)
        {
            System.Console.WriteLine("It's a leap year");
        }
        else
        {
            if(year%4==0 && year%100!=0)
            {
                System.Console.WriteLine("It's a leap year");
            }
            else
            {
                System.Console.WriteLine("It's not a leap year");
            }
        }
    }
}
