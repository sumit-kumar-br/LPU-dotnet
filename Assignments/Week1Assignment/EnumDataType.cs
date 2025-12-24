using System;
using System.Security.Cryptography.X509Certificates;

namespace Week1Assignment;

public class EnumDataType
{
    public enum Day
    {
        MONDAY, TUESDAY, WEDNESDAY, THURSDAY, FRIDAY, SATURDAY, SUNDAY
    }
    public static void EnumType()
    {
        int thisday;
        Console.WriteLine("Enter the day number (0=Monday, 1=Tuesday, 2=Wednesday, 3=Thursday, 4=Friday, 5=Saturday, 6=Sunday): ");
        thisday = Int32.Parse(Console.ReadLine());

        switch ((Day)thisday)
        {
            case Day.MONDAY:
                Console.WriteLine("Dosa"); 
                Console.WriteLine("Idly"); 
                Console.WriteLine("Poori"); 
                Console.WriteLine("Rice-bath"); 
                break;
            case Day.TUESDAY:
                Console.WriteLine("Poha");
                Console.WriteLine("Upma");
                Console.WriteLine("Paratha");
                Console.WriteLine("Sambar-rice");
                break;
            case Day.WEDNESDAY:
                Console.WriteLine("Vada");
                Console.WriteLine("Uttapam");
                Console.WriteLine("Bread-omelette");
                Console.WriteLine("Curd-rice");
                break;
            case Day.THURSDAY:
                Console.WriteLine("Pongal");
                Console.WriteLine("Medu-vada");
                Console.WriteLine("Chapati");
                Console.WriteLine("Biryani");
                break;
            case Day.FRIDAY:
                Console.WriteLine("Rava-idly");
                Console.WriteLine("Masala-dosa");
                Console.WriteLine("Aloo-paratha");
                Console.WriteLine("Fried-rice");
                break;
            case Day.SATURDAY:
                Console.WriteLine("Rava-dosa");
                Console.WriteLine("Set-dosa");
                Console.WriteLine("Puri-bhaji");
                Console.WriteLine("Lemon-rice");
                break;
            case Day.SUNDAY:
                Console.WriteLine("Appam");
                Console.WriteLine("Puttu");
                Console.WriteLine("Naan");
                Console.WriteLine("Pulao");
                break;
            default:
                Console.WriteLine("Invalid Choice");
                break;
        }
    }
}
