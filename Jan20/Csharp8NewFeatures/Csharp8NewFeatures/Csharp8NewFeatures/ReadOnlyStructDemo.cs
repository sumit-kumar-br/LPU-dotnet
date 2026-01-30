using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    public readonly struct Rectangle
    {
        public readonly double Height { get; }
        public readonly double Width { get; }
        public double Area => (Height * Width);
        public Rectangle(double height, double width)
        {
            Height = height;
            Width = width;
        }
        public override string ToString()
        {
            return $"(Total area for height: {Height}, width: {Width}) is {Area}";
        }
    }
    class ReadOnlyStructDemo
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(10, 20);
            Console.WriteLine("Height: " + rectangle.Height);
            Console.WriteLine("width: " + rectangle.Width);
            Console.WriteLine("Rectangle Area: " + rectangle.Area);
            Console.WriteLine("Rectangle: " + rectangle);
            Console.ReadKey();
        }
    }
}
