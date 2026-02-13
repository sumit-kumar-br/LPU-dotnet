    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; } = "";
        public double BasePrice { get; set; }
        public int Quantity { get; set; }
        public bool IsPremiumCustomer { get; set; }
    }

    public class PricingEngine
    {
        public void calculate(Product product, string strategy, Func<Product, double> calculator)
        {
            Console.WriteLine("========= PRICE CALCULATION =========");
            Console.WriteLine($"Product  : {product.Name}");
            Console.WriteLine($"Strategy : {strategy}");
            Console.WriteLine($"Price    : {calculator(product)}");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

        }
    }

    public class Solution
    {
        public static void Main()
        {
            Product product = new Product
            {
                ProductId = 901,
                Name = "Laptop",
                BasePrice = 60000,
                Quantity = 12,
                IsPremiumCustomer = true
            };
            Func<Product, double> festivalPricingRule = 
                s => 0.80 * s.BasePrice;
            Func<Product, double> premiumPricingRule =
                s => 0.85 * s.BasePrice;
            Func<Product, double> bulkPricingRule = 
                s => 0.75 * s.BasePrice;
            
            PricingEngine engine = new PricingEngine();
            engine.calculate(product, "Festival", festivalPricingRule);
            engine.calculate(product, "Premium", premiumPricingRule);
            engine.calculate(product, "Bulk", bulkPricingRule);
        }
    }
