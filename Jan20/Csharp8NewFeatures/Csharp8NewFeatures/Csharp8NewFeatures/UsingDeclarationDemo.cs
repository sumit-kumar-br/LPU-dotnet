using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class UsingDeclarationDemo
    {
        public static void Main()
        {
             using var resource = new Resource();
            //using (var resource = new Resource())
            //{
                resource.ResourceUsing();
            //}
           
            Console.WriteLine("Doing Some Other Task...");
        }
    }
    class Resource : IDisposable
    {
        public Resource()
        {
            Console.WriteLine("Resource Created...");
        }
        public void ResourceUsing()
        {
            Console.WriteLine("Resource Using...");
        }
        public void Dispose()
        {
            Console.WriteLine("Resource Disposed...");
        }
    }
}

