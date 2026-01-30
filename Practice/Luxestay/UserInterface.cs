using System;

namespace Luxestay
{
    public class UserInterface
    {
        public static void Main(string[] args)
        {
            string guestDeluxe;
            double rpmDeluxe;
            int nightsDeluxe;
            int joiningYearDeluxe;
            string guestSuite;
            double rpmSuite;
            int nightsSuite;
            int joiningYearSuite;
            Console.WriteLine("Enter Deluxe Room Details: ");
            Console.Write("Guest Name: ");
            guestDeluxe = Console.ReadLine();
            Console.Write("Rate per Night: ");
            rpmDeluxe = Double.Parse(Console.ReadLine());
            Console.Write("Nights Stayed: ");
            nightsDeluxe = Int32.Parse(Console.ReadLine());
            Console.Write("Joining Year: ");
            joiningYearDeluxe = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter Suite Room Details: ");
            Console.Write("Guest Name: ");            
            guestSuite = Console.ReadLine();
            Console.Write("Rate per Night: ");
            rpmSuite = Double.Parse(Console.ReadLine());
            Console.Write("Nights Stayed: ");
            nightsSuite = Int32.Parse(Console.ReadLine());
            Console.Write("Joining Year: ");
            joiningYearSuite = Int32.Parse(Console.ReadLine());

            HotelRoom deluxe = new HotelRoom("Deluxe",rpmDeluxe, guestDeluxe);
            HotelRoom suite = new HotelRoom("Suite",rpmSuite,  guestSuite);


        }
    }
}