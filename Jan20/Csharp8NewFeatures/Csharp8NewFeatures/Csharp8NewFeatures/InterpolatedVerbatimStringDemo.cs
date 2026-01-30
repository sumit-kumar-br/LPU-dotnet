using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class InterpolatedVerbatimStringDemo
    {
        static void Main()
        {
            int Base = 10;
            int Height = 30;
            int area = (Base * Height) / 2;

            // Here, $ token appears before @ token
            Console.WriteLine("Finding the area of a triangle:");
            Console.WriteLine($@"Height = ""{Height}"" and Base = ""{Base}""");
            Console.WriteLine($@"Area = ""{area}""");

            // Here, @ token appears before $ token
            // But the compiler will give an error in eralier version
            //Console.WriteLine("Finding the area of a triangle:");
            //Console.WriteLine(@ $"Height = ""{Height}"" and Base = ""{Base}""");
            //Console.WriteLine(@ $"Area = ""{area}""");
        }
    }
}
