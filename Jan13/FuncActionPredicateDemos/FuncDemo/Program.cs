using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FuncDemo.Pankaj;


namespace FuncDemo
{
    
    namespace Pankaj
    {
        class Demo
        {
            public static void DemoShow1()
            {
                List<string> myList = new List<string>();

                myList.Add("Alok");
                myList.Add("Aliya");
                myList.Add("Ashok");
                myList.Add("Riya");
                myList.Add("Rajat");

                Action<string> SearchUser = name =>
                {
                    foreach (var item in myList)
                    {
                        if (item == name)
                        {
                            Console.WriteLine(item);
                        }
                    }
                };

                SearchUser("Alok");

                Console.WriteLine(myList.Find(a => a == "Ashok"));
                bool res = myList.Exists(d => d == "Ashok");
            }
        }
    }
    class Program
    {
        static List<string> myList= new List<string>();
        public Program()
        {
          //  myList = new List<string>();
        }
        public static float MyFunc1(int x,int y)
        {
            return (float)x / y;
        }
        public static void Show1()
        {
            
            myList.Add("Alok");
            myList.Add("Aliya");
            myList.Add("Ashok");
            myList.Add("Riya");
            myList.Add("Rajat");

            Action<string> SearchUser = name =>
            {
                foreach (var item in myList)
                {
                    if (item == name)
                    {
                        Console.WriteLine(item);
                    }
                }                
            };

            SearchUser("Alok");

            Console.WriteLine(myList.Find(a=>a=="Ashok"));
            bool res= myList.Exists(d => d == "Ashok");
        }

        public static bool SearchName(string name)
        {
            bool res=false;
            foreach (var item in myList)
            {
                if(item==name)
                {
                    res =true;
                }
            }
            return res;
        }
        public static string Show()
        {
            return "Show method returned value";
        }
        static void Main(string[] args)
        {

            //Demo.DemoShow1();
            //Show1();
            //Func Delegate with 2 input parameters and one return value
            Func<double, double, double> powDel = Math.Pow;
            double power = powDel(3, 4);
            Console.WriteLine($"3 ^ 4 is : {power}");

            Func<int, int, float> divide = MyFunc1;

           float res= divide(10, 2);


            //Func Delegate with with 1 input parameter and one return value
            Func<string, bool> strDel = String.IsNullOrEmpty;
            bool result = strDel(".NET Batch");
            Console.WriteLine($"String.IsNullOrEmpty(\".NET Batch\") : {result}");

            //Func Delegate with 0 input parameter and one return value
            Func<String> showDel = Show;
            string data = showDel();
            Console.WriteLine(data);

            //Func Delegate with Anonymous Method
            Func<int, int, int> annDel = delegate (int num1, int num2)
            {
                return num1 + num2;
            };
            int sum = annDel(23, 67);
            Console.WriteLine("Annonymous method called, Addition is : " + sum);

            //Func Delegate with Lambda Expression
            Func<string, string> lbdDel = (string str) => str.ToUpper();
            string upper = lbdDel("hello");
            Console.WriteLine("Lambda Expression called, Upper case string : " + upper);

            Console.ReadKey();
        }
    }
}
