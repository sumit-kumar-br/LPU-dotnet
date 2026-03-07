// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Reflection.Metadata;
using CandyCraze;

public class Program
{
    public Candy CalculateDiscountedPrice(Candy candy)
    {
        candy.TotalPrice = candy.PricePerPiece * candy.Quantity;

        double discount = 0;
        if(candy.Flavour == "Strawberry")
        {
            discount = 15;
        }
        else if(candy.Flavour == "Lemon")
        {
            discount = 10;
        }
        else if(candy.Flavour == "Mint")
        {
            discount = 5;
        }

        candy.Discount = candy.TotalPrice - (candy.TotalPrice*discount)/100;
        return candy;
    }
    public static void Main(string[] args)
    {
        Candy candy = new Candy();

        Console.WriteLine("Enter the flavour");
        candy.Flavour = Console.ReadLine();

        if (candy.ValidateCandyFlavour())
        {
            Console.WriteLine("Enter the quantity");
            candy.Quantity = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the price per piece");
            candy.PricePerPiece = Int32.Parse(Console.ReadLine());

            Program program = new Program();
            candy = program.CalculateDiscountedPrice(candy);
            Console.WriteLine($"Total Price : {candy.TotalPrice}");
            Console.WriteLine($"Discount Price : {candy.Discount}");

        }
        else
        {
            Console.WriteLine("Invalid flavour");
            return;
        }


    }
}