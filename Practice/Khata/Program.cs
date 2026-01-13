using System;

public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, int> record = new Dictionary<string, int>
        {
            { "Milk", 100 },
            { "Tea", 50 },
            { "Coffee", 100 },
            { "Sugar", 50 },
            { "Salt", 200 }
        };

        Khata khataObj = new Khata(record);

        System.Console.WriteLine($"Total Amount: {khataObj.getTotal()}");
        System.Console.WriteLine($"Repeated Amount Count: {khataObj.getRepeatAmount()}");

    }
}