// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using HasinaCabs;

CabDetails cabDetails = new CabDetails();
Console.WriteLine("Enter the booking id");
cabDetails.BookingID = Console.ReadLine();
Console.WriteLine("Enter the cab type");
cabDetails.CabType = Console.ReadLine();
Console.WriteLine("Enter the distance in km");
cabDetails.Distance = Int32.Parse(Console.ReadLine());
Console.WriteLine("Enter the waiting time in minutes");
cabDetails.WaitingTime = Int32.Parse(Console.ReadLine());

if(cabDetails.ValidateBookingID())
{
    Console.WriteLine($"The fare amount is {cabDetails.CalculateFareAmount()}");
}
else
{
    Console.WriteLine("Invalid booking id");
}


