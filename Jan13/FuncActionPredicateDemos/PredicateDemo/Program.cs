using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PredicateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string username=null;
            string password=null;

          
            //Predicate to check whether the string is null or empty
            Predicate<string> strDel = string.IsNullOrEmpty;
            Console.WriteLine($"string.IsNullOrEmpty(null) : {strDel(null)}");

            //Predicate with Anonymous Method
            Predicate<char> charDel = delegate(char c) {
                return char.IsDigit(c);
            };
            Console.WriteLine($"Char.IsDigit('8') : {charDel('8')}");

            //Predicate with Lambda Expression
            Predicate<double> dblDel = (double val) => double.IsNaN(val);
            Console.WriteLine($"double.IsNaN(23.45) : {dblDel(23.45)}");

            Console.ReadKey();
        }
    }
}
