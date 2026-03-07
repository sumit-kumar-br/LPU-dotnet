using System;
using System.Net;

namespace Week1Assignment
{
    public class Customer
    {
        public double FeedbackRating { get; set; }
        public string MobileNum { get; set; }
        public string Name { get; set; }
    }
    public class ArrayOfObjects
    {
        public static void AverageRating()
        {
            int N;
            Console.WriteLine("Enter the number of customers");
            N = Int32.Parse(Console.ReadLine());
            Customer[] customArray = new Customer[N];
            for(int i=0; i<N; i++)
            {
                customArray[i] = new Customer();
                Console.WriteLine($"Enter the details for customer {i+1}");
                Console.Write("Feedback: ");
                customArray[i].FeedbackRating = double.Parse(Console.ReadLine());
                Console.Write("Mobile Number: ");
                customArray[i].MobileNum = Console.ReadLine();
                Console.Write("Name: ");
                customArray[i].Name = Console.ReadLine();
            }
            double sumRate = 0;
            double averageRate;
            for(int i=0; i<N; i++)
            {
                sumRate += customArray[i].FeedbackRating;
            }
            averageRate = sumRate / N;
            Console.WriteLine($"Average feedback rating:{averageRate}");
            
        }
        

        
    }
}