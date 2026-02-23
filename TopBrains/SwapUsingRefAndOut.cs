// using System;

// class Program
// {
//     // Method 1: Swap using ref (without temp)
//     static void SwapUsingRef(ref int a, ref int b)
//     {
//         a = a + b;
//         b = a - b;
//         a = a - b;
//     }

//     // Method 2: Swap using out (without temp)
//     static void SwapUsingOut(int a, int b, out int x, out int y)
//     {
//         x = a + b;
//         y = x - b;
//         x = x - y;
//     }

//     static void Main(string[] args)
//     {
//         // Using ref
//         int num1 = 5, num2 = 10;
//         SwapUsingRef(ref num1, ref num2);
//         Console.WriteLine("After SwapUsingRef:");
//         Console.WriteLine("num1 = " + num1 + ", num2 = " + num2);

//         // Using out
//         int x, y;
//         SwapUsingOut(20, 30, out x, out y);
//         Console.WriteLine("After SwapUsingOut:");
//         Console.WriteLine("x = " + x + ", y = " + y);
//     }
// }


// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;
using System.Reflection;
public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine ("Try programiz.pro");
        var t = typeof(Queue<int>);
        foreach(var s in t.GetMethods()){
            Console.WriteLine(s);
        }
    }
}