using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArchDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentDAL studDAL = new StudentDAL();

            List<Student> list = studDAL.SearchByName("Alia");

            foreach (var item in list)
            {
                Console.WriteLine($"{item.Name} {item.Address} {item.Address} {item.PhoneNo}");
            }
        }
    }
}