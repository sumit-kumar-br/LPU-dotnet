using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class IndicesAndRanges
    {
        static void Main(string[] args)
        {
            var countries = new string[]
            {
                "INDIA",
                "USA",
                "UK",
                "NZ",
                "FRANCE",
                "CANADA",
                "GERMANY",
                "CHINA",
                "NEPAL",
                "RUSIA",
                "SRILANKA",
                "INDONESIA"
            };
            Index i1 = 4;
            Console.WriteLine($"{countries[i1]}"); // Output: "FRANCE"
            // Index 4 from end of the collection
            Index i2 = ^4;
            Console.WriteLine($"{countries[i2]}"); // Output: "NEPAL"
        }
    }
}
