using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    public class NullableReferenceTypes
    {
        public static void Main()
        {
            string message = null;
           
            // warning: dereference null.
            Console.WriteLine($"The length of the message is {message.Length}");
            var originalMessage = message;
            message = "Hello, World!";
            // No warning. Analysis determined "message" is not null.
            Console.WriteLine($"The length of the message is {message.Length}");
            // warning!
            Console.WriteLine(originalMessage.Length);
        }
    }
}
