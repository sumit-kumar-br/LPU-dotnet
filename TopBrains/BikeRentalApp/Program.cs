using System;
namespace BikeRentalApp;

class Program
{
    public static SortedDictionary<int, Bike> bikeDetails = new SortedDictionary<int, Bike>();
    public static void Main(string[] args)
    {
        BikeUtility bikeUtility = new BikeUtility();
        int choice;
        do
        {
            Console.WriteLine("1. Add Bike Details");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Exit");
            Console.WriteLine();
            Console.Write("Enter your choice ");
            choice = Int32.Parse(Console.ReadLine());

            switch(choice)
            {
                case 1:
                    {
                        System.Console.WriteLine();
                        System.Console.Write("Enter the model: ");
                        string model = Console.ReadLine();
                        System.Console.Write("Enter the brand: ");
                        string brand = Console.ReadLine();
                        System.Console.Write("Enter the price per day: ");
                        int pricePerDay = int.Parse(Console.ReadLine());

                        bikeUtility.AddBikeDetails(model, brand, pricePerDay);

                        Console.WriteLine();
                        Console.WriteLine("Bike Added successfully");
                        Console.WriteLine();
                        break;
                    }
                
                case 2:
                    {
                        System.Console.WriteLine();
                        var groupedBikes = bikeUtility.GroupBikesByBrand();
                        foreach(var item in groupedBikes)
                        {
                            foreach(var bike in item.Value)
                            {
                                System.Console.WriteLine($"{item.Key} {bike.Model}");
                            }
                        }
                        System.Console.WriteLine();
                        break;
                    }
                case 3:
                    {
                        break;
                    }
                default:
                    {
                        System.Console.WriteLine("Invalid choice!!");
                        break;
                    }
            }
        } while(choice != 3);
    }
}