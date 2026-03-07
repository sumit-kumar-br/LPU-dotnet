// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;
using MediSureClinic;

class Program
{
    static PatientBill LastBill = null;
    static bool HasLastBill = false;

    public static void Register()
    {
        string billId;
        char hasInsurance;
        decimal consultationFee;
        decimal labCharges;
        decimal medicineCharges; ;
        PatientBill pObj = new PatientBill();

        Console.Write("Enter Bill Id: ");
        billId = Console.ReadLine();
        if (billId != null)
        {
            pObj.BillId = billId;
        }
        else
        {
            Console.WriteLine("Please enter the bill id");
            return;
        }
        Console.Write("Enter Patient Name: ");
        pObj.PatientName = Console.ReadLine();
        Console.Write("Is the patient insured? (Y/N): ");
        hasInsurance = char.Parse(Console.ReadLine());
        if (hasInsurance == 'Y')
        {
            pObj.HasInsurance = true;
        }
        else
        {
            pObj.HasInsurance = false;
        }

        Console.Write("Enter the Consultation fee: ");
        consultationFee = decimal.Parse(Console.ReadLine());
        if (consultationFee > 0)
        {
            pObj.ConsultationFee = consultationFee;
        }
        else
        {
            Console.WriteLine("Please enter valid Consultation fee");
            return;
        }
        Console.Write("Enter the Lab charges: ");
        labCharges = decimal.Parse(Console.ReadLine());
        if (labCharges >= 0)
        {
            pObj.LabCharges = labCharges;
        }
        else
        {
            Console.WriteLine("Please enter valid lab charges");
            return;
        }
        Console.Write("Enter the Medicine charges: ");
        medicineCharges = decimal.Parse(Console.ReadLine());
        if (medicineCharges >= 0)
        {
            pObj.MedicineCharges = medicineCharges;
        }
        else
        {
            Console.WriteLine("Please enter valid medicine charges");
            return;
        }

        pObj.GrossAmount = pObj.ConsultationFee + pObj.LabCharges + pObj.MedicineCharges;
        if (pObj.HasInsurance)
        {
            pObj.DiscountAmount = (decimal)((double)pObj.GrossAmount * 0.10);
        }
        else
        {
            pObj.DiscountAmount = 0;
        }
        pObj.FinalPayable = Math.Round((pObj.GrossAmount - pObj.DiscountAmount), 2);
        LastBill = pObj;
        HasLastBill = true;
        Console.WriteLine("Bill created successfully");
        Console.WriteLine($"Gross Amount: {pObj.GrossAmount:F2}");
        Console.WriteLine($"Discount Amount: {pObj.DiscountAmount:F2}");
        Console.WriteLine($"Final payable: {pObj.FinalPayable:F2}");
        Console.WriteLine("--------------------------------");

    }

    public static void View()
    {
        if (HasLastBill)
        {
            Console.WriteLine("----------- Last Bill -----------");
            Console.WriteLine($"BillId: {LastBill.BillId}");
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
            Console.WriteLine("No bill available. Please create a new bill first.");
        }
        Console.WriteLine("--------------------------------");
    }
    public static void Clear()
    {
        LastBill = null;
        HasLastBill = false;
    }
    public static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("================== MediSure Clinic Billing ==================");
            Console.WriteLine("1. Create New Bill (Enter Patient Details)");
            Console.WriteLine("2. View Last Bill");
            Console.WriteLine("3. Clear Last Bill");
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
                        Clear();
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