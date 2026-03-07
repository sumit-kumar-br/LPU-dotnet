// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Reflection.Metadata;
using QuickMartTraders;
class Program
{
    static SaleTransaction LastTransaction = null;
    static bool HasLastTransaction = false;
    public static void Register()
    {
        string invoiceNo;
        int quantity;
        decimal purchaseAmount;
        decimal sellingAmount;
        SaleTransaction sObj = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        invoiceNo = Console.ReadLine();
        if (invoiceNo != null)
        {
            sObj.InvoiceNo = invoiceNo;
        }
        Console.Write("Enter Customer Name: ");
        sObj.CustomerName = Console.ReadLine();
        Console.Write("Enter Item Name: ");
        sObj.ItemName = Console.ReadLine();
        Console.Write("Enter Quantity: ");
        quantity = Int32.Parse(Console.ReadLine());
        if (quantity > 0)
        {
            sObj.Quantity = quantity;
        }
        else
        {
            Console.Write("Please enter valid Quantity!!");
            return;
        }
        Console.Write("Enter Purchase Amount : ");
        purchaseAmount = decimal.Parse(Console.ReadLine());
        if (purchaseAmount > 0)
        {
            sObj.PurchaseAmount = purchaseAmount;
        }
        else
        {
            Console.Write("Please enter valid purchase amount!!");
            return;
        }
        Console.Write("Enter Selling Amount: ");
        sellingAmount = decimal.Parse(Console.ReadLine());
        if (sellingAmount >= 0)
        {
            sObj.SellingAmount = sellingAmount;
        }
        else
        {
            Console.Write("Please enter valid selling amount!!");
            return;
        }
        if (sObj.SellingAmount > sObj.PurchaseAmount)
        {
            sObj.ProfitOrLossStatus = "PROFIT";
            sObj.ProfitOrLossAmount = sObj.SellingAmount - sObj.PurchaseAmount;
        }
        else if (sObj.SellingAmount < sObj.PurchaseAmount)
        {
            sObj.ProfitOrLossStatus = "LOSS";
            sObj.ProfitOrLossAmount = sObj.PurchaseAmount - sObj.SellingAmount;
        }
        else
        {
            sObj.ProfitOrLossStatus = "BREAK-EVEN";
            sObj.ProfitOrLossAmount = 0;
        }
        sObj.ProfitMarginPercent = (sObj.ProfitOrLossAmount / sObj.PurchaseAmount) * 100;

        LastTransaction = sObj;
        HasLastTransaction = true;

        Console.WriteLine("Transaction saved sucessfully. ");
        Console.WriteLine($"Status: {sObj.ProfitOrLossStatus}");
        Console.WriteLine($"Profit/Loss Amount: {sObj.ProfitOrLossAmount:F2}");
        Console.WriteLine($"Profit Margin (%): {sObj.ProfitMarginPercent:F2}");
    }
    public static void View()
    {
        if (HasLastTransaction)
        {
            Console.WriteLine("----------- Last Transaction -----------");
            Console.WriteLine($"InvoiceNo: {LastTransaction.InvoiceNo}");
            Console.WriteLine($"Customer: {LastTransaction.CustomerName}");
            Console.WriteLine($"Item: {LastTransaction.ItemName}");
            Console.WriteLine($"Quantity: {LastTransaction.Quantity}");
            Console.WriteLine($"Purchase Amount: {LastTransaction.PurchaseAmount:F2}");
            Console.WriteLine($"Selling Amount: {LastTransaction.SellingAmount:F2}");
            Console.WriteLine($"Status: {LastTransaction.ProfitOrLossStatus}");
            Console.WriteLine($"Profit/Loss Amount: {LastTransaction.ProfitOrLossAmount:F2}");
            Console.WriteLine($"Profit Margin (%): {LastTransaction.ProfitMarginPercent:F2}");

        }
        else
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
        }
        Console.WriteLine("--------------------------------");
    }
    public static void ReCalculateProfitLoss()
    {
        if (HasLastTransaction)
        {
            if (LastTransaction.SellingAmount > LastTransaction.PurchaseAmount)
            {
                LastTransaction.ProfitOrLossStatus = "PROFIT";
                LastTransaction.ProfitOrLossAmount = LastTransaction.SellingAmount - LastTransaction.PurchaseAmount;
            }
            else if (LastTransaction.SellingAmount < LastTransaction.PurchaseAmount)
            {
                LastTransaction.ProfitOrLossStatus = "LOSS";
                LastTransaction.ProfitOrLossAmount = LastTransaction.PurchaseAmount - LastTransaction.SellingAmount;
    
            }
            else
            {
                LastTransaction.ProfitOrLossStatus = "BREAK-EVEN";
                LastTransaction.ProfitOrLossAmount = 0;
            }
            LastTransaction.ProfitMarginPercent = (LastTransaction.ProfitOrLossAmount / LastTransaction.PurchaseAmount) * 100;
            View();
        }
        else
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
        }
        Console.WriteLine("--------------------------------");
    }
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("================== QuickMart Traders ==================");
            Console.WriteLine("1. Create New Transaction (Enter Purchase & Selling Details)");
            Console.WriteLine("2. View Last Transaction");
            Console.WriteLine("3. Calculate Profit/Loss (Recompute & Print)");
            Console.WriteLine("4. Exit");
            int ch;
            Console.Write("Enter your option: ");
            ch = Int32.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Register();
                        break;
                    }
                case 2:
                    {
                        View();
                        break;
                    }
                case 3:
                    {
                        ReCalculateProfitLoss();
                        break;
                    }
                case 4:
                    {
                        Console.WriteLine("Thank you. Application closed normally.");
                        return;
                    }
                default:
                    {
                        Console.WriteLine("Invalid option!!! Please choice a valid option");
                        break;
                    }
            }

        }
    }
}