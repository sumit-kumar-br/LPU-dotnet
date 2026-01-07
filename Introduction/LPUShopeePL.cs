using System;
using MyRetailLogic;

class AddProgram
{
    static void Main()
    {
        int prod1;
        int prod2;
        int finalAmt;

        Console.Write("Enter First Number : ");
        prod1 = Int32.Parse(Console.ReadLine());

        Console.Write("Enter Second Number : ");
        prod2 = Int32.Parse(Console.ReadLine());

        // BL
        RetailLogic rlobj = new RetailLogic();
        int total = prod1+prod2;
        int disc = rlobj.CalcDiscount(total); 
        finalAmt = total-disc;

        // Print
        Console.WriteLine("LPU Shopee");
        Console.WriteLine("Cost of First Product is {0}", prod1);
        Console.WriteLine("Cost of Second Product is {0}", prod2);
        Console.WriteLine("Total amount is {0}", total);
        Console.WriteLine("Discount is {0}", disc);
        Console.WriteLine("Amount payable is {0}", finalAmt);
    }
}
