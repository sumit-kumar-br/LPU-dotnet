using System;

namespace DigitalPettyCash;

public class ExpenseTransaction: Transaction
{
    public string Category { get; set; }
    public override string GetSummary()
    {
        return $"[DEBIT] {Date.ToShortDateString()} | {Category} | {Amount} | {Description}";
    }
}
