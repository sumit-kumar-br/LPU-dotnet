using System;

namespace BikeOnRent_App
{
    class Program
    {
        public static void Menu()
        {
            Console.WriteLine("BIKE RENTAL SERVICE");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Add Bike");
            Console.WriteLine("2. Group Bikes By Brand");
            Console.WriteLine("3. Filter Bikes By Max Price");
            Console.WriteLine("4. Search Bikes By Model");
            Console.WriteLine("5. Count Bikes Per Brand");
            Console.WriteLine("6. Sort Bikes By Price");
            Console.WriteLine("7. Cheapest Bike");
            Console.WriteLine("8. Costliest Bike");
            Console.WriteLine("9. View All Brands");
            Console.WriteLine("10. Exit");
        }
        static void Main(string[] args)
        {
            var service = new BikeService(new BikeRepository());
            int choice;

            do
            {
                
                Console.Write("Enter your choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Model: ");
                            var model = Console.ReadLine();
                            Console.Write("Brand: ");
                            var brand = Console.ReadLine();
                            Console.Write("Price per day: ");
                            var price = int.Parse(Console.ReadLine());
                            service.AddBike(model, brand, price);
                            Console.WriteLine("Bike added successfully");
                            break;
                        }

                    case 2:
                        {
                            foreach (var g in service.GroupByBrand())
                            {
                                Console.WriteLine(g.Key);
                                g.Value.ForEach(b => Console.WriteLine(b.Model));
                            }
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Max price: ");
                            service.FilterByMaxPrice(int.Parse(Console.ReadLine()))
                                .ForEach(b => Console.WriteLine($"{b.Brand} - {b.Model}"));
                            break;
                        }

                    case 4:
                        {
                            Console.Write("Search model: ");
                            service.SearchByModel(Console.ReadLine())
                                .ForEach(b => Console.WriteLine($"{b.Brand} - {b.Model}"));
                            break;
                        }

                    case 5:
                        {
                            foreach (var c in service.CountByBrand())
                                Console.WriteLine($"{c.Key} : {c.Value}");
                            break;
                        }

                    case 6:
                        {
                            Console.Write("1.Asc  2.Desc : ");
                            bool asc = Console.ReadLine() == "1";
                            service.SortByPrice(asc)
                                .ForEach(b => Console.WriteLine($"{b.Brand} - {b.Model} - {b.PricePerDay}"));
                            break;
                        }

                    case 7:
                        {
                            var cheap = service.GetCheapestBike();
                            Console.WriteLine($"{cheap.Brand} - {cheap.Model} - {cheap.PricePerDay}");
                            break;
                        }

                    case 8:
                        {
                            var costly = service.GetCostliestBike();
                            Console.WriteLine($"{costly.Brand} - {costly.Model} - {costly.PricePerDay}");
                            break;
                        }

                    case 9:
                        {
                            service.GetDistinctBrands().ForEach(Console.WriteLine);
                            break;
                        }
                }

            } while (choice != 10);
        }
    }

}
    
