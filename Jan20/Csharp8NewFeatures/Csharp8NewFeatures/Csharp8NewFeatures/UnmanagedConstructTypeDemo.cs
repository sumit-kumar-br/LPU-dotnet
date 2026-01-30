using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{

    public struct Point3D<T>
    {
        public T X;
        public T Y;
        public T Z;
    }
       public class UnmanagedConstructTypeDemo
        {
            public static void Main()
            {
            // Block of memory
            Span<Point3D<double>> points = stackalloc[]
            {
                new Point3D<double> { X = 0.0, Y = 0.0, Z = 0.0 },
                new Point3D<double> { X = 0.0, Y = 3.0, Z = 0.0 },
                new Point3D<double> { X = 4.0, Y = 0.0, Z = 0.0 }
            };
            foreach (var point in points)
            {
                Console.WriteLine("X: {0}, Y: {1}, Z: {2}", point.X, point.Y, point.Z);
            }
        }
        }
    }

