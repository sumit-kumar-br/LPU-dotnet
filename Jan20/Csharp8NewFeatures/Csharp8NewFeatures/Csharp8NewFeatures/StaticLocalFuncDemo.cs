using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp8NewFeatures
{
    internal class StaticLocalFuncDemo
    {
        public static void Main()
        {
            Calculate();
        }

        public static void Calculate()
        {
            int X = 20, Y = 30;
            CalculateSum(X, Y);
            static void CalculateSum(int Num1, int Num2)
            {
                int sum = Num1 + Num2;
                Console.WriteLine($"Num1 = {Num1}, Num2 = {Num2}, Result = {sum}");
            }
            CalculateSum(30, 10);
            CalculateSum(80, 60);
        }
    }
}
