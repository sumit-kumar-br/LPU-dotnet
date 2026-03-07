// some OOPS Questions

using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static double CalculateCircleArea(double radius)
    {
        double area = Math.PI * radius * radius;
        return Math.Round(area, 2, MidpointRounding.AwayFromZero);
    }
    public static double ConvertFeetToCentimetres(int valueInFeet)
    {
        double valueInCm = valueInFeet * 30.48;
        return Math.Round(valueInCm, 2, MidpointRounding.AwayFromZero);
    }
    public static string HeightCategory(int height)
    {
        if(height < 150)
        {
            return "Short";
        }
        else if(height < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }
    public static void Main(String[] args)
    {
        // double radius;
        // Console.WriteLine("Enter the radius");
        // radius = Double.Parse(Console.ReadLine());
        // Console.WriteLine($"Area of circle is {CalculateCircleArea(radius)}");

        // int valueInFeet;
        // Console.WriteLine("Enter the value in feet");
        // valueInFeet = Int32.Parse(Console.ReadLine());
        // Console.WriteLine($"Value in centimetres is {ConvertFeetToCentimetres(valueInFeet)}");

        int heightInCm;
        Console.WriteLine("Enter the height in cm");
        heightInCm = Int32.Parse(Console.ReadLine());
        Console.WriteLine($"Height Category: {HeightCategory(heightInCm)}");



    }
}