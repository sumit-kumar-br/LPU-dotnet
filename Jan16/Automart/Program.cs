using System;

namespace AutoMart
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarUtility carUtility = new CarUtility();

            Console.WriteLine("Enter the model");
            carUtility.Model = Console.ReadLine();

            if (!carUtility.ValidateCarModel())
            {
                Console.WriteLine("Invalid car model");
                return; // Stop execution if model is invalid
            }

            Console.WriteLine("Enter the body style");
            carUtility.BodyStyle = Console.ReadLine();

            Console.WriteLine("Enter the price");
            if (double.TryParse(Console.ReadLine(), out double inputPrice))
            {
                carUtility.Price = inputPrice;
            }
            else
            {
                Console.WriteLine("Invalid price input");
                return;
            }

            // Calculate discount and return updated Car object
            Car result = carUtility.PriceCalculation();
            
            // Calculate tax on the discounted price
            double finalPrice = carUtility.CalculateFinalPriceWithTax(result.Price);

            Console.WriteLine($"Model:{result.Model}");
            Console.WriteLine($"Body Style:{result.BodyStyle}");
            Console.WriteLine($"Price After Discount:{result.Price}");
            Console.WriteLine($"Final Price with Tax:{finalPrice}");
        }
    }

    public class Car
    {
        public string Model { get; set; }
        public string BodyStyle { get; set; }
        public double Price { get; set; }
    }

    public class CarUtility : Car
    {
        public bool ValidateCarModel()
        {
            // Using a switch or an array is often cleaner for multiple values
            return (Model == "A3" || Model == "A8" || Model == "Q5");
        }

        public Car PriceCalculation()
        {
            double discount = 0;
            if (BodyStyle == "Sedan")
                discount = 0.05;
            else if (BodyStyle == "SUV")
                discount = 0.10;

            Price -= (Price * discount);

            return new Car 
            { 
                Model = this.Model, 
                BodyStyle = this.BodyStyle, 
                Price = this.Price 
            };
        }

        public double CalculateFinalPriceWithTax(double discountedPrice)
        {
            double taxRate = 0;

            // Fixed the logic gaps (inclusive boundaries)
            if (discountedPrice <= 1000000)
                taxRate = 0.05;
            else if (discountedPrice > 1000000 && discountedPrice <= 2000000)
                taxRate = 0.08;
            else
                taxRate = 0.15;

            return discountedPrice + (discountedPrice * taxRate);
        }
    }
}