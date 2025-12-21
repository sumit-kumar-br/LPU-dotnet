using System;

namespace Day2PracticeQuestions;

public class TriangleType
{  
    public static void checkType()
    {
        int side1;
        int side2;
        int side3;
        System.Console.WriteLine("Enter the first side of the triangle:");
        side1 = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the second side of the triangle:");
        side2 = Int32.Parse(Console.ReadLine());
        System.Console.WriteLine("Enter the third side of the triangle:");
        side3 = Int32.Parse(Console.ReadLine());
        if(side1==side2 && side2 == side3)
        {
            System.Console.WriteLine("The triangle is equilateral");
        }
        else if(side1==side2 || side2 == side3 || side3==side1)
        {
            System.Console.WriteLine("The triangle is isosceles");
        }
        else
        {
            System.Console.WriteLine("The triangle is scalene");
        }

    }
}
