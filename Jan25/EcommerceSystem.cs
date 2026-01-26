using System;
using System.Collections.Generic;

namespace EcommerceAssessment
{
    // =========================
    // TASK 3: Custom Delegate
    // =========================
    public delegate void OrderCallback(string message);

    // =========================
    // TASK 1: Generic Repository
    // =========================
    public class Repository<T>
    {
        private List<T> items = new List<T>();

        public void Add(T item)
        {
            items.Add(item);
        }

        public List<T> GetAll()
        {
            return items;
        }
    }

    // =========================
    // TASK 2: Order Domain Model
    // =========================
    public class Order
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public double Amount { get; set; }

        public override string ToString()
        {
            return $"OrderId: {OrderId}, Customer: {CustomerName}, Amount: {Amount}";
        }
    }

    // =========================
    // TASK 4: Order Processor
    // =========================
    public class OrderProcessor
    {
        public event Action<string> OrderProcessed;

        public void ProcessOrder(
            Order order,
            Func<double, double> taxCalculator,
            Func<double, double> discountCalculator,
            Predicate<Order> validator,
            OrderCallback callback)
        {
            if (!validator(order))
            {
                callback("Order validation failed.");
                return;
            }

            double tax = taxCalculator(order.Amount);
            double discount = discountCalculator(order.Amount);

            order.Amount = order.Amount + tax - discount;

            callback($"Order {order.OrderId} processed successfully.");
            OrderProcessed?.Invoke($"Event: Order {order.OrderId} completed.");
        }
    }

    // =========================
    // TASK 5: Main Execution
    // =========================
    class Program
    {
        static void Main()
        {
            // 1. Repository
            Repository<Order> orderRepository = new Repository<Order>();

            // 2. Add Orders
            orderRepository.Add(new Order { OrderId = 1, CustomerName = "Alice", Amount = 5000 });
            orderRepository.Add(new Order { OrderId = 2, CustomerName = "Bob", Amount = 2000 });
            orderRepository.Add(new Order { OrderId = 3, CustomerName = "Charlie", Amount = 8000 });

            // 3. Tax Calculator (18%)
            Func<double, double> taxCalculator = amount => amount * 0.18;

            // 4. Discount Calculator (10%)
            Func<double, double> discountCalculator = amount => amount * 0.10;

            // 5. Validation (minimum amount 2500)
            Predicate<Order> validator = order => order.Amount >= 2500;

            // 6. Callback
            OrderCallback callback = message =>
            {
                Console.WriteLine($"Callback: {message}");
            };

            // 7. Notification Handlers
            Action<string> logger = message =>
            {
                Console.WriteLine($"Logger: {message}");
            };

            Action<string> notifier = message =>
            {
                Console.WriteLine($"Notifier: {message}");
            };

            // 8. Multicast Delegate
            Action<string> multicast = logger + notifier;

            // Processor
            OrderProcessor processor = new OrderProcessor();

            // 9. Subscribe Event
            processor.OrderProcessed += multicast;

            // 10. Process Orders
            foreach (var order in orderRepository.GetAll())
            {
                processor.ProcessOrder(
                    order,
                    taxCalculator,
                    discountCalculator,
                    validator,
                    callback);
            }

            // 11. Sort Orders (Descending Amount)
            List<Order> orders = orderRepository.GetAll();
            orders.Sort((o1, o2) => o2.Amount.CompareTo(o1.Amount));

            // 12. Display Sorted Orders
            Console.WriteLine("\nSorted Orders (Descending Amount):");
            foreach (var order in orders)
            {
                Console.WriteLine(order);
            }
        }
    }
}
