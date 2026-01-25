// File: BankTransactionValidator.cs
using System;
using System.Collections.Generic;

class BankTransactionValidator
{
    static void Main()
    {
        Console.WriteLine("=== BANK TRANSACTION VALIDATOR ===\n");
        
        // Sample data: AccountType, Balance, WithdrawalAmount, TransactionsToday, TransactionsThisMonth
        List<(char, double, double, int, int)> transactions = new List<(char, double, double, int, int)>
        {
            ('S', 500.00, 200.00, 0, 2),   // Savings, valid
            ('S', 100.00, 50.00, 0, 3),    // Savings, below min balance after withdrawal
            ('C', 1000.00, 1200.00, 0, 0), // Checking, exceeds withdrawal limit
            ('S', 800.00, 100.00, 2000, 4),// Savings, exceeds daily limit
            ('S', 600.00, 50.00, 0, 5),    // Savings, exceeds monthly free transactions
            ('C', 200.00, 150.00, 0, 0)    // Checking, valid
        };
        
        foreach (var transaction in transactions)
        {
            ValidateTransaction(
                transaction.Item1, // account type
                transaction.Item2, // balance
                transaction.Item3, // withdrawal amount
                transaction.Item4, // transactions today
                transaction.Item5  // transactions this month
            );
            Console.WriteLine("------------------------");
        }
    }
    
    static void ValidateTransaction(char accountType, double balance, double withdrawalAmount, 
                                    int transactionsToday, int transactionsThisMonth)
    {
        Console.WriteLine($"Account Type: {GetAccountTypeName(accountType)}");
        Console.WriteLine($"Current Balance: ${balance:F2}");
        Console.WriteLine($"Withdrawal Amount: ${withdrawalAmount:F2}");
        Console.WriteLine($"Transactions Today: {transactionsToday}");
        Console.WriteLine($"Transactions This Month: {transactionsThisMonth}");
        
        List<string> errors = new List<string>();
        List<string> warnings = new List<string>();
        
        // Check minimum balance after withdrawal
        if (balance - withdrawalAmount < 50)
        {
            errors.Add("Minimum balance of $50 required");
        }
        
        // Check per-transaction limit
        if (withdrawalAmount > 1000)
        {
            errors.Add("Maximum withdrawal per transaction is $1000");
        }
        
        // Check daily withdrawal limit
        if (transactionsToday + withdrawalAmount > 5000)
        {
            errors.Add("Maximum daily withdrawal limit is $5000");
        }
        
        // Check savings account transaction limits and fees
        if (accountType == 'S')
        {
            if (transactionsThisMonth >= 3)
            {
                warnings.Add("Transaction fee of $1 will be applied (exceeds 3 free monthly transactions)");
            }
        }
        
        // Display results
        if (errors.Count > 0)
        {
            Console.WriteLine("\n❌ TRANSACTION DENIED");
            Console.WriteLine("Reasons:");
            foreach (string error in errors)
            {
                Console.WriteLine($"  • {error}");
            }
        }
        else
        {
            Console.WriteLine("\n✅ TRANSACTION APPROVED");
            
            // Calculate new balance
            double newBalance = balance - withdrawalAmount;
            double fee = 0;
            
            // Apply fee for savings account if needed
            if (accountType == 'S' && transactionsThisMonth >= 3)
            {
                fee = 1.00;
                newBalance -= fee;
            }
            
            if (warnings.Count > 0)
            {
                Console.WriteLine("Notes:");
                foreach (string warning in warnings)
                {
                    Console.WriteLine($"  • {warning}");
                }
                if (fee > 0)
                {
                    Console.WriteLine($"  • Fee applied: ${fee:F2}");
                }
            }
            
            Console.WriteLine($"New Balance: ${newBalance:F2}");
        }
    }
    
    static string GetAccountTypeName(char accountType)
    {
        return accountType switch
        {
            'S' => "Savings",
            'C' => "Checking",
            _ => "Unknown"
        };
    }
}