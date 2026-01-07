using System;
using DigitalPettyCash;
class Program
{
    static void Main()
    {
        Ledger<IncomeTransaction> incomeLedger = new Ledger<IncomeTransaction>();
        Ledger<ExpenseTransaction> expenseLedger = new Ledger<ExpenseTransaction>();

        Console.WriteLine("Enter Income Details");
        Console.Write("Id: ");
        string incomeId = Console.ReadLine();

        Console.Write("Amount: ");
        decimal incomeAmount = decimal.Parse(Console.ReadLine());

        Console.Write("Description: ");
        string incomeDesc = Console.ReadLine();

        Console.Write("Source: ");
        string source = Console.ReadLine();

        incomeLedger.AddEntry(new IncomeTransaction
        {
            ID = incomeId,
            Date = DateTime.Today,
            Amount = incomeAmount,
            Description = incomeDesc,
            SourceProperty = source
        });

        Console.WriteLine("\nEnter number of expense entries:");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"\nExpense {i + 1}");

            Console.Write("Id: ");
            string expenseId = Console.ReadLine();

            Console.Write("Amount: ");
            decimal expenseAmount = decimal.Parse(Console.ReadLine());

            Console.Write("Description: ");
            string expenseDesc = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            expenseLedger.AddEntry(new ExpenseTransaction
            {
                ID = expenseId,
                Date = DateTime.Today,
                Amount = expenseAmount,
                Description = expenseDesc,
                Category = category
            });
        }

        decimal totalIncome = incomeLedger.CalculateTotal();
        decimal totalExpense = expenseLedger.CalculateTotal();
        decimal balance = totalIncome - totalExpense;

        Console.WriteLine("\n----- SUMMARY -----");
        Console.WriteLine($"Total Income   : {totalIncome}");
        Console.WriteLine($"Total Expenses : {totalExpense}");
        Console.WriteLine($"Net Balance    : {balance}");

        Console.WriteLine("\n--- Transaction Report ---");

        List<Transaction> allTransactions = new List<Transaction>();

        foreach (IncomeTransaction entry in incomeLedger.GetAll())
            allTransactions.Add(entry);

        foreach (ExpenseTransaction entry in expenseLedger.GetAll())
            allTransactions.Add(entry);

        foreach (Transaction entry in allTransactions)
            Console.WriteLine(entry.GetSummary());
    }
}
