// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

public class Program
{
    public static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
    public static void Main(String[] args)
    {
        double radius;
        Console.WriteLine("Enter the radius");
        radius = Double.Parse(Console.ReadLine());
        Console.WriteLine($"Area of circle is {CalculateCircleArea(radius)}");

    }
}