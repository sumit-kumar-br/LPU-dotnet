// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Threading;

namespace EventDelegateDemo
{
    public delegate bool CreateRecord(Product p);
    public delegate void Caller(string str);
    delegate string strDelegate(string str);
    public class Handler
    {
        public static string UpperCase(string s)
        {
            Thread.Sleep(5000);
            return s.ToUpper();
        }
    }
    class Program
    {
        public static void ShowMe(string str)
        {
            Console.WriteLine("ShowMe called");
        }
        public void GenerateBill(string str)
        {
            Console.WriteLine("GenerateBill called");
        }
        static void Main(string[] args)
        {
            //ProductRepo pRepo = new ProductRepo();
            //CreateRecord AddProduct = new CreateRecord(pRepo.Add);
            //AddProduct(new Product());

            // Program p1 = new Program();
            // Caller CallMe = new Caller(Program.ShowMe);
            // CallMe += new Caller(p1.GenerateBill);
            // CallMe("LPU");
            // CallMe -= new Caller(p1.GenerateBill);
            // CallMe("LPU");

            strDelegate caller = new strDelegate(Handler.UpperCase);
            //string res = caller("ThE quICk BrOWn FoX");
            //Console.WriteLine(res);
            //Console.WriteLine("Demo on Async delegate");

            IAsyncResult result = caller.BeginInvoke("ThE quICk BrOWn FoX", null, null);
            Console.WriteLine("Demo on Async delegate");
            string returnValue = caller.EndInvoke(result);
        }
    }
    
}