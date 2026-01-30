using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
    class Address
    {
        public string City { get; set; }
    }

    internal class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Address Address { get; set; }
        
    }
    internal class ExtendedPropertyDemo
    {
        public static void ExtendedPropertyMain()
        {
            var obj = new Employee
            {
                Name = "Alok",
                Age = 22,
                Address = new Address { City = "Delhi" }
            };

            Console.Write($" Name : {obj.Name} Age: {obj.Age}");

            if (obj is Employee { Address: { City: "Mumbai" } })
                Console.Write($"City: {obj.Address.City}");

            // Extended property pattern
            if (obj is Employee { Address.City: "Delhi" }) 
                Console.Write($" City: {obj.Address.City}");
            Console.ReadKey();
        }
    }
}
