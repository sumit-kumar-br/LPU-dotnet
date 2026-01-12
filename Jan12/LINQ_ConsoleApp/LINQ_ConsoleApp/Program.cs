using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    internal class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 27 };
            string[] nameArray = { "Alok", "Rajat", "Yousuf", "Sumit", "Priya", "Ayush", "Harshita", "Himanshu", "Mahi", "Mandabi", "Gaurav", "Yash", "Mahesh" };

            //foreach(var item in numArray)
            //{
            //    if(item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}

            // LINQ
            //var result = from data in numArray
            //             where data % 2 == 0 && data > 20
            //             select data;
            //var res = numArray
            //        .Where(data => data % 2 == 0 && data > 20)
            //        .Select(data => data);
            var name = from data in nameArray
                       where data.Contains('A') || data.Contains('a')
                       select data;

            //foreach (var item in result)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            //foreach (var item in res)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}
            foreach (var item in name)
            {
                Console.WriteLine(item);
            }
            string dataToSearch;
            Console.WriteLine("Enter data to search");
            dataToSearch = Console.ReadLine();
            var result = nameArray.Where(n => n == dataToSearch);


        }

        public static void LinqToObjectDemoOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer{CustomerId=101, Name="Alok", City="Pune"},
                new Customer{CustomerId=102, Name="Sumit", City="Mumbai"},
                new Customer{CustomerId=103, Name="Prachi", City="Hyderabad"},
                new Customer{CustomerId=104, Name="Khushi", City="Mumbai"},
                new Customer{CustomerId=105, Name="Danish", City="Pune"},
                new Customer{CustomerId=106, Name="Sanjana", City="Mumbai"},
                new Customer{CustomerId=107, Name="Sanju", City="Hyderabad"},
                new Customer(){CustomerId=108, Name="Sweta", City="Mumbai"}, // '()' is optional
            };

            //var result = custList.Where(n => n.City == "Mumbai");
            //var result1 = from cust in custList
            //          where cust.City == "Mumbai"
            //          select new {
            //              cust.Name,
            //              cust.City
            //          };
            var data = new { OrderID = 1100, OrderDate = "12/01/2026", TotalAmount = 14000 };
            var result = custList.Where(cust => cust.City == "Mumbai");
            var result1 = custList.Find(cust => cust.City == "Pune"); // use find for primary key 
            foreach(var item in result)
            {
                Console.WriteLine($"{item.Name}\t{item.CustomerId}\t{item.City}");
            }
        }
        public static void LambdaLookup()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var query = numbers.ToLookup(i => i % 2);
            foreach (IGrouping<int, int> group in query)
            {
                Console.WriteLine("Key: {0}", group.Key);
                foreach (int number in group)
                {
                    Console.WriteLine(number);
                }
            }
        }
        public static void LambdaLookupOnStudents()
        {
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();

            var query = tempList.ToLookup(s => s.Gender == "Male");
            foreach (IGrouping<bool, Student> group in query)
            {
                int totFees = 0;
                //Console.WriteLine("Key: {0}", group.Key);
                if(group.Key == true)
                {
                    Console.WriteLine("Male students detail below");
                }
                else
                {
                    Console.WriteLine("Female students detail below");
                }
                foreach (Student std in group)
                {
                    Console.WriteLine($"\t{std.Name}");
                    totFees += std.Fees;
                }
                Console.WriteLine($"Total Fees Paid : {totFees}");
            }
            //var maleFeesPaid = tempList.ToLookup(s => s.Gender == "Male").Sum();
        }
        static void Main(string[] args)
        {
            //LinqToObjectDemo();
            //LinqToObjectDemoOnCustomType();
            //LambdaLookup();
            //LambdaLookupOnStudents();
            StudentRepo sRepo = new StudentRepo();
            List<Student> tempList = sRepo.GetAllStudents();
            var total = tempList.Select(s => s.Fees).Sum();
            var min = tempList.Select(s => s.Fees).Min();
            Console.WriteLine(total);
            Console.WriteLine(min);
            Console.WriteLine(tempList.Sum(s => s.Gender == "Male" ? s.Fees : 0));
        }
    }
}
