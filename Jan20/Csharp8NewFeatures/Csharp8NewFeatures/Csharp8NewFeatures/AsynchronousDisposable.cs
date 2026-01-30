using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class AsynchronousDisposable
    {
      
        static async Task Main(string[] args)
        {
            await using (var disposableObject = new Sample())
            {
                Console.WriteLine("Welcome to C#.NET");
            } // DisposeAsync method called implicitly
            Console.WriteLine("Main Method End");
        }
    }
    public class Sample : IAsyncDisposable
    {
        static readonly string filePath = @"D:\MyTextFile1.txt";
        private TextWriter? textWriter = File.CreateText(filePath);
        public async ValueTask DisposeAsync()
        {
            if (textWriter != null)
            {
                textWriter = null;
            }
            await Task.Delay(1000);
            Console.WriteLine("DisposeAsync Clean-up the Memory!");
        }
    }
}
