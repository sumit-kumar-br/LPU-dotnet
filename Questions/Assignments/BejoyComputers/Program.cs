// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;
using BejoyComputers;
int device;
Console.WriteLine("1. Desktop");
Console.WriteLine("2. Laptop");
Console.WriteLine("Choose the option");
device=Int32.Parse(Console.ReadLine());

switch(device)
{
    case 1:
        {
            Desktop desktop = new Desktop();
            Console.WriteLine("Enter the processor: ");
            desktop.Processor = Console.ReadLine();
            Console.WriteLine("Enter the ram size: ");
            desktop.RamSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size: ");
            desktop.HardDiskSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the graphic card size: ");
            desktop.GraphicCard = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the monitor size: ");
            desktop.MonitorSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the power supply volt: ");
            desktop.PowerSupplyVolt = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Desktop Price is {desktop.DesktopPriceCalculation()}");
            break;
        }
        

    case 2:
        {
            Laptop laptop = new Laptop();
            Console.WriteLine("Enter the processor: ");
            laptop.Processor = Console.ReadLine();
            Console.WriteLine("Enter the ram size: ");
            laptop.RamSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the hard disk size: ");
            laptop.HardDiskSize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the graphic card size: ");
            laptop.GraphicCard = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the display size: ");
            laptop.DisplaySize = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter the battery volt: ");
            laptop.BatteryVolt = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Laptop Price is {laptop.LaptopPriceCalculation()}");
            break;
        }
        

    default:
        {
            Console.WriteLine("Invalid Choice !!!");
            break;
        }    
}
