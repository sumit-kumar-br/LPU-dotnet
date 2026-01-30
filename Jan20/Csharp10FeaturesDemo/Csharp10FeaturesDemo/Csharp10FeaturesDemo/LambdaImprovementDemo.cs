using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp10FeaturesDemo
{
    internal class LambdaImprovementDemo
    {
        public delegate void Mydelegate(Product product);
        static void Main(string[] args)
        {
            // C#9
            //Func getUserInput = Console.ReadLine;
            //Action tellUser = (string s) => Console.WriteLine(s);
            //Func waitForEnter = Console.ReadLine;

            //tellUser("Please enter name");
            //var name = getUserInput();
            //tellUser($"Your name is {name}");
            //waitForEnter();

            //    // C#10
            var getUserInput = Console.ReadLine;
            var tellUser = (string s) => Console.WriteLine(s);
            var waitForEnter = Console.ReadLine;

            //old Syntax
            Mydelegate ShowProdDetails = new Mydelegate(DisplayDetails);
            //New Way to do in C#10
            var ShowProductDetails = DisplayDetails;

            tellUser("Please enter name");
            var name = getUserInput();
            tellUser($"Your name is {name}");
            waitForEnter();
            ShowProductDetails(new Product() { CategoryId = 1, Name = "Product 1" });
            ShowProdDetails(new Product() { CategoryId = 101, Name = "ABC Product" });
        }

        static void DisplayDetails(Product p)
        {
            Console.WriteLine(p.Name);
        }
    }
}
