using System;
using System.Collections.Generic;


class Electronics
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public string Brand { get; set; }
    public double Price { get; set; }
}

class Grocery
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public double Price { get; set; }
}


class Inventory<T>
{
    private List<T> items = new List<T>();

    public void AddItem(T item) 
    {
        items.Add(item);
    }
    public List<T> GetAllItems() 
    {
        return items;
    }
    public T FindItem(Predicate<T> match) 
    {
        foreach(T item in items) 
        {
            if(match(item))
            {
                return item;
            }
        }
        return default(T);
    }
    public bool RemoveItem(Predicate<T> match)
    {
        for(int i=0; i<items.Count; i++) 
        {
            if(match(items[i]))
            {
                items.RemoveAt(i);
                return true;
            }
        }
        return false;
    }
}


class Program
{
    static void Main()
    {
        Inventory<Electronics> electronicsInventory = new Inventory<Electronics>();
        electronicsInventory.AddItem(new Electronics { ProductID=1, Name="Laptop", Brand="Dell", Price=65000 });
        electronicsInventory.AddItem(new Electronics { ProductID=2, Name="Mobile", Brand="Samsung", Price=30000 });

        Inventory<Grocery> groceryInventory = new Inventory<Grocery>();
        groceryInventory.AddItem(new Grocery{ProductID=101, Name="Rice", Quantity=10, Price=500});
        groceryInventory.AddItem(new Grocery{ProductID=102, Name="Sugar", Quantity=5, Price=200});

        Console.WriteLine("---- Electronics Inventory ----");
        foreach(Electronics e in electronicsInventory.GetAllItems())
        {
            Console.WriteLine($"ID: {e.ProductID}, Name: {e.Name}, Brand: {e.Brand}, Price: {e.Price}");
        }
        Console.WriteLine();
        Console.WriteLine("---- Grocery Inventory ----");
        foreach(Grocery g in groceryInventory.GetAllItems())
        {
            Console.WriteLine($"ID: {g.ProductID}, Name: {g.Name}, Qty: {g.Quantity}, Price: {g.Price}");
        }
        Console.WriteLine();
        Electronics foundProduct = electronicsInventory.FindItem(e => e.ProductID == 1);
        Console.WriteLine("---- Find Electronics Product (ID = 1) ----");
        if (foundProduct != null)
        {
            Console.WriteLine($"Found: {foundProduct.Name} - {foundProduct.Brand}");
        }
        Console.WriteLine();
        Console.WriteLine("---- Remove Grocery Product (ID = 102) ----");
        bool removed = groceryInventory.RemoveItem(g => g.ProductID == 102);
        Console.WriteLine(removed ? "Product Removed Successfully" : "Product Not Found");

        Console.WriteLine();
        Console.WriteLine("---- Updated Grocery Inventory ----");
        foreach (Grocery g in groceryInventory.GetAllItems())
        {
            Console.WriteLine($"ID: {g.ProductID}, Name: {g.Name}, Qty: {g.Quantity}, Price: {g.Price}");
        }

        Console.WriteLine();
        Console.WriteLine("Generic Inventory System Executed Successfully");

    }
}
