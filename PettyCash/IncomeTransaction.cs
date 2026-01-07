using System;

namespace DigitalPettyCash;

public class IncomeTransaction: Transaction
{
    public string SourceProperty { get; set; }
    public override string GetSummary()
    {
        return $"[CREDIT] {Date.ToShortDateString()} | {SourceProperty} | {Amount} | {Description}";

    }
}
