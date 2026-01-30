using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class StackMemoryAllocation
    {
        public static void Main()
        {
            //The stackalloc operator allocates a memory block in the stack. A memory block is created during 
            //the execution of the method, and it is automatically deleted when the method is returned.
            Span<int> set = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var subSet = set.Slice(3, 2);
            foreach (var n in subSet)
            {
                Console.WriteLine(n); // Output: 4 5
            }

            string input = "This is a simple string \r\n";
            // it trims the input string from three special characters.
            ReadOnlySpan<char> trimmedChar = input.AsSpan().Trim(stackalloc[] { ' ', '\r', '\n' });

            Console.WriteLine(trimmedChar.ToString());
        }
    }
}
