using System;
using System.Collections.Generic;
using System.Linq;

// =======================
// 1️⃣ Base Interface
// =======================
public interface IProduct
{
    int Id { get; }
    string Name { get; }
    decimal Price { get; }
    Category Category { get; }
}

public enum Category { Electronics, Clothing, Books, Groceries }

// =======================
// 2️⃣ Generic Repository
// =======================
public class ProductRepository<T> where T : class, IProduct
{
    private List<T> _products = new();

    public void AddProduct(T product)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        if (_products.Any(p => p.Id == product.Id))
            throw new InvalidOperationException("Product ID must be unique.");

        if (product.Price <= 0)
            throw new InvalidOperationException("Price must be positive.");

        if (string.IsNullOrWhiteSpace(product.Name))
            throw new InvalidOperationException("Name cannot be empty.");

        _products.Add(product);
        Console.WriteLine($"Added: {product.Name}");
    }

    public IEnumerable<T> FindProducts(Func<T, bool> predicate)
    {
        return _products.Where(predicate);
    }

    public decimal CalculateTotalValue()
    {
        return _products.Sum(p => p.Price);
    }

    public List<T> GetAll() => _products;

    // Immutable update (replace object instead of mutating)
    public void UpdateProduct(int id, Func<T, T> updater)
    {
        int index = _products.FindIndex(p => p.Id == id);

        if (index == -1)
            throw new InvalidOperationException("Product not found.");

        _products[index] = updater(_products[index]);
    }
}

// =======================
// 3️⃣ Concrete Products
// =======================
public class ElectronicProduct : IProduct
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public decimal Price { get; init; }
    public Category Category => Category.Electronics;
    public int WarrantyMonths { get; init; }
    public string Brand { get; init; } = "";
}

public class BookProduct : IProduct
{
    public int Id { get; init; }
    public string Name { get; init; } = "";
    public decimal Price { get; init; }
    public Category Category => Category.Books;
    public string Author { get; init; } = "";
}

// =======================
// 4️⃣ Discount Wrapper
// =======================
public class DiscountedProduct<T> where T : IProduct
{
    private readonly T _product;
    private readonly decimal _discount;

    public DiscountedProduct(T product, decimal discountPercentage)
    {
        if (product == null)
            throw new ArgumentNullException(nameof(product));

        if (discountPercentage < 0 || discountPercentage > 100)
            throw new ArgumentOutOfRangeException(nameof(discountPercentage));

        _product = product;
        _discount = discountPercentage;
    }

    public decimal DiscountedPrice =>
        _product.Price - (_product.Price * _discount / 100);

    public override string ToString()
    {
        return $"{_product.Name} | Original: {_product.Price:C} | " +
               $"Discount: {_discount}% | Final: {DiscountedPrice:C}";
    }
}

// =======================
// 5️⃣ Inventory Manager
// =======================
public class InventoryManager
{
    public void ProcessProducts(IEnumerable<IProduct> products)
    {
        if (products == null || !products.Any())
        {
            Console.WriteLine("No products available");
            return;
        }

        Console.WriteLine("\n📦 Product List");
        foreach (var p in products)
            Console.WriteLine($"{p.Name} - {p.Price:C}");

        var mostExpensive = products
            .OrderByDescending(p => p.Price)
            .First();

        Console.WriteLine($"\n💎 Most Expensive: {mostExpensive.Name} - {mostExpensive.Price:C}");

        Console.WriteLine("\n📊 Grouped By Category:");
        var grouped = products.GroupBy(p => p.Category);

        foreach (var group in grouped)
        {
            Console.WriteLine(group.Key);
            foreach (var item in group)
                Console.WriteLine($"   {item.Name}");
        }

        Console.WriteLine("\n⚡ Electronics Over $500 With 10% Discount:");
        var electronics = products
            .Where(p => p.Category == Category.Electronics && p.Price > 500);

        foreach (var product in electronics)
        {
            var discounted = new DiscountedProduct<IProduct>(product, 10);
            Console.WriteLine(discounted);
        }
    }
}

// =======================
// 6️⃣ Test Scenario
// =======================
public class Program
{
    public static void Main()
    {
        var electronicsRepo = new ProductRepository<ElectronicProduct>();

        electronicsRepo.AddProduct(new ElectronicProduct
        {
            Id = 1,
            Name = "Laptop",
            Price = 1200,
            Brand = "Dell",
            WarrantyMonths = 24
        });

        electronicsRepo.AddProduct(new ElectronicProduct
        {
            Id = 2,
            Name = "Smartphone",
            Price = 800,
            Brand = "Samsung",
            WarrantyMonths = 12
        });

        electronicsRepo.AddProduct(new ElectronicProduct
        {
            Id = 3,
            Name = "Headphones",
            Price = 150,
            Brand = "Sony",
            WarrantyMonths = 12
        });

        Console.WriteLine("\n🔎 Find Electronics by Brand: Samsung");
        var samsungProducts =
            electronicsRepo.FindProducts(p => p.Brand == "Samsung");

        foreach (var product in samsungProducts)
            Console.WriteLine(product.Name);

        Console.WriteLine($"\n💰 Total Before Update: {electronicsRepo.CalculateTotalValue():C}");

        // Immutable Update (increase price by 5%)
        electronicsRepo.UpdateProduct(1, old =>
            new ElectronicProduct
            {
                Id = old.Id,
                Name = old.Name,
                Brand = old.Brand,
                WarrantyMonths = old.WarrantyMonths,
                Price = old.Price * 1.05m
            });

        Console.WriteLine($"\n💰 Total After Update: {electronicsRepo.CalculateTotalValue():C}");

        // Mixed collection demo
        var mixedInventory = new List<IProduct>();
        mixedInventory.AddRange(electronicsRepo.GetAll());

        mixedInventory.Add(new BookProduct
        {
            Id = 10,
            Name = "C# in Depth",
            Price = 50,
            Author = "Jon Skeet"
        });

        var manager = new InventoryManager();
        manager.ProcessProducts(mixedInventory);
    }
}
