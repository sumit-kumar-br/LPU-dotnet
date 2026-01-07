using System;
using System.Collections.Generic;
using System.Linq;

public class Customer
{   public int Id { get; set; }
    public string Name { get; set; }
}

public class Program
{
    public static void Main()
    {
        // Example dictionary
        Dictionary<int, Dictionary<int, Customer>> customerDict = new Dictionary<int, Dictionary<int, Customer>>
        {
            { 1, new Dictionary<int, Customer> 
                {
                    { 101, new Customer { Id = 101, Name = "Alice" } },
                    { 102, new Customer { Id = 102, Name = "Bob" } }
                }
            },
            { 2, new Dictionary<int, Customer> 
                {
                    { 201, new Customer { Id = 201, Name = "Charlie" } },
                    { 202, new Customer { Id = 202, Name = "David" } }
                }
            }
        };

        // Convert to List<Customer>
        List<Customer> customerList = customerDict
                                        .SelectMany(d => d.Value.Values)
                                        .ToList();

        // Print the list of customers
        foreach (var customer in customerList)
        {
            Console.WriteLine($"Id: {customer.Id}, Name: {customer.Name}");
        }
    }
}