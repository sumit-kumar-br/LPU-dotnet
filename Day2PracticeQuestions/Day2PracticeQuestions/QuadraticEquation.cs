using System;

namespace Day2PracticeQuestions;

public class QuadraticEquation
{
    public static void QuadEquation(int a, int b, int c)
    {
        double d = b*b-4*a*c;
        if(d<0)
        {
            System.Console.WriteLine("Roots are imaginary");
        }
        else if(d==0)
        {
            double r = -1.0*b/(2*a);
            System.Console.WriteLine("Roots are real and equal: {0}, {1}",r,r);
        }
        else
        {
            double r1, r2;
            r1 = (-1*b+Math.Sqrt(d))/(2*a);
            r2 = (-1*b-Math.Sqrt(d))/(2*a);
            System.Console.WriteLine("Roots are real and unequal: {0}, {1}",r1,r2);

        }
    }
}
