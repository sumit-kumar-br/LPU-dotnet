using System;

namespace Day2PracticeQuestions;

public class ElectricityBill
{
    public static void CalculateBill(int units)
    {
        double amt;
        if(units <= 199)
        {
            amt=units*1.20;
        }
        else if(units <= 399)
        {
            amt = (units-199)*1.50 + 199*1.20;  
        }
        else if(units <= 599)
        {
            amt = (units-399)*1.80 + 200*1.50 + 199*1.20;
        }
        else
        {
            amt = (units-599)*2.00 + 200*1.80 + 200*1.50 + 199*1.20;
        }
        if(units>400)
        {
            amt += amt*15/100;
        }
        System.Console.WriteLine("Total bill: Rs.{0}",amt);
    }
}
