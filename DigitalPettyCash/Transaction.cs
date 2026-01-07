using System;

namespace DigitalPettyCash;

public interface IReportable
{
    string GetSummary();
}
public abstract class Transaction
{
    public string ID { get; set; }
    public DateTime Date { get; set; }
    public decimal Amount { get; set; }
    public string Description { get; set; }
    public abstract string GetSummary();
}
