

using ServiceLibrary;
using System;

namespace UILogic
{
    [Doctor(Name = "Ravi", CheckedOnDate = "12/02/2025")]
    [Doctor(Name = "Neha", CheckedOnDate = "16/03/2025")]
    [Doctor(Name = "Shashi", CheckedOnDate = "22/04/2025")]
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.Write("Enter 1st Number:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter 2nd Number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            int numResult = logic.AddMe(num1, num2);
            Console.WriteLine($"The Sum of {num1} and {num2} is {numResult}");

            Doctor atr = (Doctor)Attribute.GetCustomAttribute(typeof(Program), typeof(Doctor));

            Console.ReadLine();
        }
    }
}