using System;
using System.Collections.Generic;

public class Bike
{
    public string Model { get; set; }
    public string Brand { get; set; }
    public int PricePerDay { get; set; }
}

public class BikeUtility
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();

    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int nextKey = bikeDetails.Count + 1;
        bikeDetails.Add(nextKey, new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        });
    }

    public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
    {
        SortedDictionary<string, List<Bike>> groupedBikes = new SortedDictionary<string, List<Bike>>();

        foreach (Bike bike in bikeDetails.Values)
        {
            if (!groupedBikes.ContainsKey(bike.Brand))
            {
                groupedBikes[bike.Brand] = new List<Bike>();
            }
            groupedBikes[bike.Brand].Add(bike);
        }

        return groupedBikes;
    }
}

class Program
{
    static void Main()
    {
        BikeUtility bikeUtility = new BikeUtility();
        int userChoice;

        do
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.WriteLine("Enter your choice");

            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Console.WriteLine("Enter the model");
                string model = Console.ReadLine();

                Console.WriteLine("Enter the brand");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter the price per day");
                int pricePerDay = int.Parse(Console.ReadLine());

                bikeUtility.AddBikeDetails(model, brand, pricePerDay);
                Console.WriteLine("Bike details added successfully");
                Console.WriteLine();
            }
            else if (userChoice == 2)
            {
                SortedDictionary<string, List<Bike>> groupedResult = bikeUtility.GroupBikesByBrand();

                foreach (var entry in groupedResult)
                {
                    Console.WriteLine(entry.Key);
                    foreach (Bike bike in entry.Value)
                    {
                        Console.WriteLine(bike.Model);
                    }
                    Console.WriteLine();
                }
            }

        } while (userChoice != 3);
    }
}
