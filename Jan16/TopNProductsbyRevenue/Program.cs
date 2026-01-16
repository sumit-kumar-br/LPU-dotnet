using System;
using System.Collections.Generic;
using System.Linq;

class Transaction
{
    public string TransactionID { get; set; }
    public string ProductID { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
    public DateTime TransactionDate { get; set; }

    public Transaction() { }

    public Transaction(string transactionID, string productID,
                       int quantity, double price, DateTime transactionDate)
    {
        TransactionID = transactionID;
        ProductID = productID;
        Quantity = quantity;
        Price = price;
        TransactionDate = transactionDate;
    }
}

class TopNProductsByRevenue
{
    static void Main()
    {
        List<Transaction> salesTransactions = new List<Transaction>
        {
            new Transaction("1","1",10,23.9,DateTime.Now),
            new Transaction("2","1",11,21.9,DateTime.Now),
            new Transaction("3","2",12,21.9,DateTime.Now),
            new Transaction("4","3",11,24.9,DateTime.Now),
            new Transaction("5","3",4,23.9,DateTime.Now),
            new Transaction("6","3",5,26.9,DateTime.Now),
            new Transaction("7","2",6,27.9,DateTime.Now),
            new Transaction("8","1",12,28.9,DateTime.Now)
        };

        int N = 2;

        DateTime threeMonthsAgo = DateTime.Now.AddMonths(-3);

        var productRevenueMap = salesTransactions
            .Where(t => t.TransactionDate > threeMonthsAgo)
            .GroupBy(t => t.ProductID)
            .Select(g => new
            {
                ProductID = g.Key,
                Revenue = g.Sum(t => t.Price * t.Quantity)
            })
            .OrderByDescending(x => x.Revenue)
            .Take(N)
            .ToList();

        Console.WriteLine($"Top {N} products by revenue in the last 3 months:");
        foreach (var item in productRevenueMap)
        {
            Console.WriteLine($"ProductID: {item.ProductID}, Revenue: {item.Revenue}");
        }
    }
}
