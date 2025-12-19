using System;

namespace Day2PracticeQuestions;

public class LargestOfThree
{
    public static void Largest(int num1, int num2, int num3)
    {
        if (num1 >= num2)
        {
            if (num1 >= num3)
            {
                System.Console.WriteLine("{0} is greatest",num1);
            }
            else
            {
                System.Console.WriteLine("{0} is greatest",num3);
            }
        }
        else
        {
            if (num2 > num3)
            {
                System.Console.WriteLine("{0} is greatest", num2);
            }
            else
            {
                System.Console.WriteLine("{0} is greatest",num3);
            }
        }
    }
}
