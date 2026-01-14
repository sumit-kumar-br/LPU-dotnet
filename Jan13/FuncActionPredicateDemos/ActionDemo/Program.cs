using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDemo
{
    class Program
    {
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine($"{num1} + {num2} = {(num1 + num2)}");
        }

        public static void Show(string str)
        {
            Console.WriteLine($"Upper case : {str.ToUpper()}");
        }
        static void Main(string[] args)
        {
            //Action Delegate with 2 input parameters and no return value
            Action<int, int> addDel = Addition;
            addDel(23, 90);

            //Action Delegate with 1 input parameters and no return value
            Action<string> strDel = Show;
            strDel("batch");

            //Action Delegate with Anonymous Method
            Action anDel = delegate {
                Console.WriteLine("Anonymous Method");
            };
            anDel();

            //Action Delegate with Lambda Expression
            Action<string> lbdDel = (message) => Console.WriteLine($"Message from Lambda Expression : {message}");
            lbdDel("Hello");
            Console.ReadKey();
        }
    }
}
