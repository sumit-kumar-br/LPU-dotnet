// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System.Runtime.CompilerServices;
using Prac;

public class Program
{
    // public static List<int> Check(List<int> inputList)
    // {
    //     var query = inputList.Where(s=>s%2==0).ToList();
    //     return query;
    // } 
    public static void Main(string[] args)
    {
        // System.Console.WriteLine("Enter the no. of input string: ");
        // int n = Int32.Parse(Console.ReadLine());
        // List<int> inputList = new List<int>();
        // for(int i=0; i<n; i++)
        // {
        //     System.Console.Write($"Enter the {i+1} element: ");
        //     inputList.Add(Int32.Parse(Console.ReadLine()));
        // }
        // List<int> outList = Check(inputList);
        // System.Console.WriteLine("Even numbers are: ");
        // foreach(var item in outList)
        // {
        //     System.Console.Write(item);
        // }
        List<Employee> emp = new List<Employee>()
        {
            new Employee{ID=101, Name="Ram"},
            new Employee{ID=102, Name="Shyam"},
            new Employee{ID=103, Name="Sam"},
            new Employee{ID=104, Name="Dhruv"},
            new Employee{ID=105, Name="Shiv"},
        };
        Employee query = emp.FirstOrDefault(s=>s.ID==103);
        if(emp!=null)
        {
            System.Console.WriteLine($"employee found {query.ID} | {query.Name}");
        }

    }
}