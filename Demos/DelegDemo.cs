using System;
namespace DelegDemo
{
    delegate void Delegate1(ref string str);
    class sample
    {
        public static void Demofunc( ref string a)
        {
            a = a.Substring( 7, a.Length - 7);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Delegate1 str1;
            string str = "Excuses are the nails used to build a house of failure";
            str1 = sample.Demofunc;
            str1(ref str);
            Console.WriteLine(str);
        }
    }
}
	
	
-------------------------------
a. Test Your
b. ur C#.NET
c. ur C#.NET Skills
d. None of the mentioned
-----------------
Answer: (c).
ur C#.NET Skills
