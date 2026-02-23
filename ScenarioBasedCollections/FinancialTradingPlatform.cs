// Scenario 4: Financial Trading Platform
// Problem: Build a type-safe trading system for different financial instruments.
// csharp
public interface IFinancialInstrument
{
    string Symbol { get; }
    decimal CurrentPrice { get; }
    InstrumentType Type { get; }
}

public enum InstrumentType { Stock, Bond, Option, Future }

// 1. Generic portfolio
public class Portfolio<T> where T : IFinancialInstrument
{
    private Dictionary<T, int> _holdings = new(); // Instrument -> Quantity
    
    // TODO: Buy instrument
    public void Buy(T instrument, int quantity, decimal price)
    {
        // Validate: quantity > 0, price > 0
        // Add to holdings or update quantity
    }
    
    // TODO: Sell instrument
    public decimal? Sell(T instrument, int quantity, decimal currentPrice)
    {
        // Validate: enough quantity
        // Remove/update holdings
        // Return proceeds (quantity * currentPrice)
    }
    
    // TODO: Calculate total value
    public decimal CalculateTotalValue()
    {
        // Sum of (quantity * currentPrice) for all holdings
    }
    
    // TODO: Get top performing instrument
    public (T instrument, decimal returnPercentage)? GetTopPerformer(
        Dictionary<T, decimal> purchasePrices)
    {
        // Calculate return percentage for each
        // Return highest performer
    }
}

// 2. Specialized instruments
public class Stock : IFinancialInstrument
{
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public InstrumentType Type => InstrumentType.Stock;
    public string CompanyName { get; set; }
    public decimal DividendYield { get; set; }
}

public class Bond : IFinancialInstrument
{
    public string Symbol { get; set; }
    public decimal CurrentPrice { get; set; }
    public InstrumentType Type => InstrumentType.Bond;
    public DateTime MaturityDate { get; set; }
    public decimal CouponRate { get; set; }
}

// 3. Generic trading strategy
public class TradingStrategy<T> where T : IFinancialInstrument
{
    // TODO: Execute strategy on portfolio
    public void Execute(Portfolio<T> portfolio, 
        Func<T, bool> buyCondition,
        Func<T, bool> sellCondition)
    {
        // For each instrument in market data
        // Apply buy/sell conditions
        // Execute trades
    }
    
    // TODO: Calculate risk metrics
    public Dictionary<string, decimal> CalculateRiskMetrics(IEnumerable<T> instruments)
    {
        // Return: Volatility, Beta, Sharpe Ratio
    }
}

// 4. Price history with generics
public class PriceHistory<T> where T : IFinancialInstrument
{
    private Dictionary<T, List<(DateTime, decimal)>> _history = new();
    
    // TODO: Add price point
    public void AddPrice(T instrument, DateTime timestamp, decimal price)
    {
        // Add to history
    }
    
    // TODO: Get moving average
    public decimal? GetMovingAverage(T instrument, int days)
    {
        // Calculate simple moving average
    }
    
    // TODO: Detect trends
    public Trend DetectTrend(T instrument, int period)
    {
        // Return: Upward, Downward, Sideways
    }
}

public enum Trend { Upward, Downward, Sideways }

// 5. TEST SCENARIO: Trading simulation
// a) Create portfolio with mixed instruments
// b) Implement buy/sell logic
// c) Create trading strategy with lambda conditions
// d) Track price history
// e) Demonstrate:
//    - Portfolio rebalancing
//    - Risk calculation
//    - Trend detection
//    - Performance comparison
