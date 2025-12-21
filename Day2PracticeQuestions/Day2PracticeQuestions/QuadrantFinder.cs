using System;

namespace Day2PracticeQuestions;

public class QuadrantFinder
{
    public static void FindQuadrant()
    {
        int x;
        int y;
        Console.WriteLine("Enter the x-coordinate");
        x=Int32.Parse(Console.ReadLine()); 
        Console.WriteLine("Enter the y-coordinate");
        y=Int32.Parse(Console.ReadLine()); 
        if(x==0 && y==0)
        {
            Console.WriteLine("Coordinate is on origin");
        }
        else if(x==0 && y!=0)
        {
            Console.WriteLine("Coordinate is on y-axis");
        }
        else if(x!=0 && y==0)
        {
        Console.WriteLine("Coordinate is on x-axis");
        }
        else if(x>0)
        {
            if (y > 0)
            {
                Console.WriteLine("Coordinate is in first Quadrant");
            }
            else
            {
                Console.WriteLine("Coordinate is in fourth Quadrant");
            }
        }
        else
        {
            if (y > 0)
            {
                Console.WriteLine("Coordinate is in second Quadrant");
            }
            else
            {
                Console.WriteLine("Coordinate is in third Quadrant");
            }
        }
    }
}
