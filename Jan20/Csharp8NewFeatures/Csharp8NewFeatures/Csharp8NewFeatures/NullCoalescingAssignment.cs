using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class NullCoalescingAssignment
    {
        static void Main(string[] args)
        {
            int? Age = null;
            Age ??= 20;
            Console.WriteLine(Age);
        }
    }
}
