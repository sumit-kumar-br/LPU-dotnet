using System;

class Program
{
    // Method to determine height category
    static string GetHeightCategory(int heightCm)
    {
        if (heightCm < 150)
        {
            return "Short";
        }
        else if (heightCm < 180)
        {
            return "Average";
        }
        else
        {
            return "Tall";
        }
    }

    static void Main()
    {
        // Example input
        int heightCm = 172;

        string category = GetHeightCategory(heightCm);

        Console.WriteLine("Height category: " + category);
    }
}
