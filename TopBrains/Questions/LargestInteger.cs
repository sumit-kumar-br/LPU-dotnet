using System;

class Program
{
    // Method to find the largest of three integers
    static int LargestOfThree(int a, int b, int c)
    {
        int largest;

        if (a >= b && a >= c)
        {
            largest = a;
        }
        else if (b >= a && b >= c)
        {
            largest = b;
        }
        else
        {
            largest = c;
        }

        return largest;
    }

    static void Main()
    {
        // Example input
        int a = 10;
        int b = 25;
        int c = 15;

        int result = LargestOfThree(a, b, c);

        Console.WriteLine("Largest number is: " + result);
    }
}
