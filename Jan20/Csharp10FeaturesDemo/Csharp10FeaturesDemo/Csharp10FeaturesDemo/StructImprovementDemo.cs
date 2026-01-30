using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
    public record struct Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        
    }
    internal class StructImprovementDemo
    {
        public static void StructMain()
        {
            var person1 = new Person { FirstName = "Alok", LastName = "Goyal", Age = 22 };
            Console.WriteLine($"{person1.FirstName}\t {person1.LastName}\t {person1.Age}");

            //with expression on struct
            var person2 = person1 with { FirstName = "Riya" };
            Console.WriteLine($"{person2.FirstName}\t {person2.LastName}\t {person2.Age}");
        }
    }
}
