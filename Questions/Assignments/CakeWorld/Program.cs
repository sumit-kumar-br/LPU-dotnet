// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using CakeWorld;

string flavour;
int quantity;
double pricePerKg;

Cake cake = new Cake();

Console.WriteLine("Enter the flavour");
cake.Flavour = Console.ReadLine();
Console.WriteLine("Enter the quantity in kg");
cake.QuantityInKg = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the price per kg");
cake.PricePerKg = Double.Parse(Console.ReadLine());

try
{
    bool check = cake.CakeOrder();
    double price = cake.CalculatePrice();
    Console.WriteLine("Cake order was successful");
    Console.WriteLine($"Price after discount is {price}");
}
catch(InvalidFlavourException e)
{
    Console.WriteLine(e.Message);
}
catch(InvalidQuantityException e)
{
    Console.WriteLine(e.Message);
}


