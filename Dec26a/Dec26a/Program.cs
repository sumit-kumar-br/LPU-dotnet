// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using Dec26b;

namespace Dec26a
{
    class Monitor: Product
    {
        public Monitor(string str): base(str)
        {
            
        }
        public string Parts
        {
            get
            {
                return Ingridients;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();

        }
    }
}