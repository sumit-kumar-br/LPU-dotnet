using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    interface IDefaultInterfaceMethod
    {
        public void DefaultMethod()
        {
            Console.WriteLine("I am a default method in the interface!");
        }
        

        // void Display();
    }
    class AnyClass : IDefaultInterfaceMethod
    {
        public void DefaultMethod()
        {
            Console.WriteLine("I am a default method in the Class!");
        }
    }
    class DefaultInterfaceDemo
    {
        static void Main(string[] args)
        {
            IDefaultInterfaceMethod anyClass = new AnyClass();
            anyClass.DefaultMethod();
           
            Console.ReadKey();
        }
    }
}