// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Linq;

public class Program
{
    public void ArrayDemo()
    {
        string[] cities =
        {
            "Delhi",
            "Chennai",
            "Agra",
            "Pune",
            "Agartala",
            "Coorg",
            "Madekeri",
            "Nashik"
        };
        Customer[] custArray;
        custArray = new Customer[1];

        //Init the object
        custArray[0] = new Customer();
        custArray[0].ID = 101;
        custArray[0].Name = "Sumit";

        // Init the address class
        custArray[0].BillingAddress = new Address();
        custArray[0].BillingAddress.FlatNo = "1802";
        custArray[0].BillingAddress.BuildingName = "Sky Tower";
        custArray[0].BillingAddress.Street = "Bhumkar Chowk, Wakad";
        custArray[0].BillingAddress.City = "Pune";

        //foreach(var item in cities)
        //{
        //    if(item.Length > 4)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Cyan;
        //        Console.WriteLine(item);
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Yellow;
        //        Console.WriteLine(item);
        //    }
        //    Console.ForegroundColor = ConsoleColor.White;
        //}
    }
    public static void Main(String[] args)
    {
        Program progObj = new Program();
        progObj.ArrayDemo();
    }
}
