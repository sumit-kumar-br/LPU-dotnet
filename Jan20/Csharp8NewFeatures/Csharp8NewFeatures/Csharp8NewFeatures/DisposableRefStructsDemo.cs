using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class DisposableRefStructsDemo
    {
        public static void Main()
        {
            using var book = new Rectangles(10, 20);
            //using (var book = new Rectangles(10, 20))
            //{
            //    Console.WriteLine($"Area of Rectangle : {book.GetArea()}");
            //}
           Console.WriteLine($"Area of Rectangle : {book.GetArea()}");
            Console.WriteLine("Main Method End");
        }
    }
    ref struct Rectangles   
    {
        private double Height { get; set; }
        private double Width { get; set; }
        public Rectangles(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public double GetArea()
        {
            return Height * Width;
        }
        public void Dispose()
        {
            Console.WriteLine("Rectangle Object Disposed Of");
        }
    }
}
