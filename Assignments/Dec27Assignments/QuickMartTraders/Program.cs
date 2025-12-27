// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using System.Reflection.Metadata;
using QuickMartTraders;
class Program
{
    static SaleTransaction LastTransaction = null;
    static bool HasLastTransaction = false;
    public static void register()
    {
        string invoiceNo;
        int quantity;
        decimal purchaseAmount;
        decimal sellingAmount;
        SaleTransaction sObj = new SaleTransaction();

        Console.Write("Enter Invoice No: ");
        invoiceNo = Console.ReadLine();
        if(invoiceNo != null)
        {
            sObj.InvoiceNo = invoiceNo;
        }
        Console.Write("Enter Customer Name: ");
        sObj.CustomerName = Console.ReadLine();
        Console.Write("Enter Item Name: ");
        sObj.ItemName = Console.ReadLine();
        Console.Write("Enter Quantity: ");
        quantity = Int32.Parse(Console.ReadLine());
        if(quantity > 0)
        {
            sObj.Quantity = quantity;
        }
        else
        {
            Console.Write("Please enter valid Quantity!!");
            return;
        }
        Console.Write("Enter Purchase Amount : ");
        purchaseAmount = Int32.Parse(Console.ReadLine());
        if(purchaseAmount > 0)
        {
            sObj.PurchaseAmount = purchaseAmount;
        }
        else
        {
            Console.Write("Please enter valid purchase amount!!");
            return;
        }
        Console.Write("Enter Selling Amount: ");
        sellingAmount = Int32.Parse(Console.ReadLine());
        if(sellingAmount >= 0)
        {
            sObj.SellingAmount = sellingAmount;
        }
        else
        {
            Console.Write("Please enter valid selling amount!!");
            return;
        }
        if(sObj.SellingAmount > sObj.PurchaseAmount)
        {
            sObj.ProfitOrLossStatus = "PROFIT";
            sObj.ProfitOrLossAmount = sObj.SellingAmount - sObj.PurchaseAmount;
        } 
        else if(sObj.SellingAmount < sObj.PurchaseAmount)
        {
            sObj.ProfitOrLossStatus = "LOSS";
            sObj.ProfitOrLossAmount = sObj.PurchaseAmount - sObj.SellingAmount;
        }
        else
        {
            sObj.ProfitOrLossStatus = "BREAK-EVEN";
            sObj.ProfitOrLossAmount = 0;
        }
        sObj.ProfitMarginPercent = (decimal)((double)sObj.ProfitOrLossAmount*100.0/(double)sObj.PurchaseAmount);
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
            Console.WriteLine($"InvoiceNo: {LastBill.InvoiceNo}");
            Console.WriteLine($"Patient: {LastBill.PatientName}");
            if (LastBill.HasInsurance)
            {
                Console.WriteLine($"Insured: Yes");
            }
            else
            {
                Console.WriteLine($"Insured: No");
            }
            Console.WriteLine($"Consultation Fee: {LastBill.ConsultationFee:F2}");
            Console.WriteLine($"Lab Charges: {LastBill.LabCharges:F2}");
            Console.WriteLine($"Medicine Charges: {LastBill.MedicineCharges:F2}");
            Console.WriteLine($"Gross Amount: {LastBill.GrossAmount:F2}");
            Console.WriteLine($"Discount Amount: {LastBill.DiscountAmount:F2}");
            Console.WriteLine($"Final Payable: {LastBill.FinalPayable:F2}");

        }
        else
        {
            Console.WriteLine("No transaction available. Please create a new transaction first.");
        }
        Console.WriteLine("--------------------------------");
    }
}