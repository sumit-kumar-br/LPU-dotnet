// Problem: Design a flexible inventory system that can handle different product categories with varying attributes while maintaining type safety. 
// csharp

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Base product interface
public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; }
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// 1. Create a generic repository for products
public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new List<T>();
    
    // TODO: Implement method to add product with validation
    public void AddProduct(T product)
    {
        // Rule: Product ID must be unique
        // Rule: Price must be positive
        // Rule: Name cannot be null or empty
        // Add to collection if validation passes
        if(product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }
        if(_products.Any(p => p.Id == product.Id))
        {
            throw new InvalidOperationException("Product ID must be unique.");
        }
        if(product.Price < 0)
        {
            throw new InvalidOperationException("Price must be positive.");
        }
        if(string.IsNullOrWhiteSpace(product.Name))
        {
            throw new InvalidOperationException("Name cannot be null or empty");
        }
        _products.Add(product);
        System.Console.WriteLine($"Added: {product.Name}");
    }
    
    // TODO: Create method to find products by predicate
    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        // Should return filtered products
        return _products.Where(predicate);
    }
    
    // TODO: Calculate total inventory value
    public decimal CalculateTotalValue()
    {
        // Return sum of all product prices
        return _products.Sum(p => p.Price);
    }
    public List<T> GetAll() => _products;
}

// 2. Specialized electronic product
public class ElectronicProduct : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public decimal Price { get; set; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; set; }
    public string Brand { get; set; } = "";
}

// 3. Create a discounted product wrapper
public class DiscountedProduct<T> where T : IProduct
{
    private T _product;
    private decimal _discountPercentage;
    
    public DiscountedProduct(T product, decimal discountPercentage)
    {
        // TODO: Initialize with validation
        // Discount must be between 0 and 100
        if(product == null)
        {
            throw new ArgumentNullException(nameof(product));
        }
        if(discountPercentage < 0 || discountPercentage > 100)
        {
            throw new InvalidOperationException("Discount must be between 0 and 100");
        }
        _product = product;
        _discountPercentage = discountPercentage;
    }
    
    // TODO: Implement calculated price with discount
    public decimal DiscountedPrice => _product.Price * (1 - _discountPercentage / 100);

    // TODO: Override ToString to show discount details
    public override string ToString()
    {
        return $"{_product.Name} | Original: {_product.Price} | Discount: {_discountPercentage} | Final: {DiscountedPrice}";
    }
}

// 4. Inventory manager with constraints
public class InventoryManager
{
    // TODO: Create method that accepts any IProduct collection
    public void ProcessProducts<T>(IEnumerable<T> products) where T : IProduct
    {
        // a) Print all product names and prices
        // b) Find the most expensive product
        // c) Group products by category
        // d) Apply 10% discount to Electronics over $500
        if(products == null || !products.Any())
        {
            System.Console.WriteLine("No products available");
            return;
        }
        System.Console.WriteLine("Products List");
        foreach(var product in products)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }

        var mostExpensive = products.MaxBy(p => p.Price);
        Console.WriteLine($"\nMost Expensive product: {mostExpensive.Name} - {mostExpensive.Price}");

        var groupedProduct = products.GroupBy(p => p.Category);
        System.Console.WriteLine("Products grouped by category: ");
        foreach(var product in groupedProduct)
        {
            Console.WriteLine($"{product.Category} - {product.Name}");
        }

        var electronics = products.Where(p => p.Category == Category.Electronics && p.Price >= 500);
        foreach(var product in electronics)
        {
            var discount = new DiscountedProduct<T>(product, 10);
            Console.WriteLine(discount);
        }

    }
    
    // TODO: Implement bulk price update with delegate
    public void UpdatePrices<T>(List<T> products, Func<T, decimal> priceAdjuster) 
        where T : IProduct
    {
        // Apply priceAdjuster to each product
        // Handle exceptions gracefully
        for(int i=0; i<products.Count; i++)
        {
            try
            {
                var oldProduct = products[i];
                var newPrice = priceAdjuster(oldProduct);

                products[i] =newPrice;
            }
            catch(Exception e)
            {
                Console.WriteLine($"Error updating {product.Name}: {e.Message}");
            }
        }
    }
}

// 5. TEST SCENARIO: Your tasks:
// a) Implement all TODO methods with proper error handling
// b) Create a sample inventory with at least 5 products
// c) Demonstrate:
//    - Adding products with validation
//    - Finding products by brand (for electronics)
//    - Applying discounts
//    - Calculating total value before/after discount
//    - Handling a mixed collection of different product types
public class Program
{
    public static void Main()
    {
        var repo = new ProductRepository<ElectronicProduct>();

        repo.AddProduct(new ElectronicProduct
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200,
            Brand = "Dell",
            WarrantyMonths = 24
        });

        repo.AddProduct(new ElectronicProduct
        {
            Id = 2,
            Name = "Smartphone",
            Price = 800,
            Brand = "Samsung",
            WarrantyMonths = 12
        });

        repo.AddProduct(new ElectronicProduct
        {
            Id = 3,
            Name = "Headphones",
            Price = 150,
            Brand = "Sony",
            WarrantyMonths = 12
        });

        Console.WriteLine("\n🔎 Find by Brand: Samsung");
        var samsungProducts = repo.FindProducts(p => p.Brand == "Samsung");
        foreach (var p in samsungProducts)
            Console.WriteLine(p.Name);

        Console.WriteLine($"\n💰 Total Value Before Update: {repo.CalculateTotalValue():C}");

        var manager = new InventoryManager();

        // Bulk Price Increase (5%)
        manager.UpdatePrices(repo.GetAll(),
            p => p.Price * 1.05m);

        Console.WriteLine($"\n💰 Total Value After 5% Increase: {repo.CalculateTotalValue():C}\n");

        manager.ProcessProducts(repo.GetAll());
    }
}