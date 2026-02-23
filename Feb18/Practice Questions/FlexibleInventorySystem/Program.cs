/*
using System;
using FlexibleInventorySystem.Services;
using FlexibleInventorySystem.Models;

namespace FlexibleInventorySystem
{
    /// <summary>
    /// TODO: Implement console user interface
    /// </summary>
    class Program
    {
        private static InventoryManager _inventory = new InventoryManager();
        
        static void Main(string[] args)
        {
            // TODO: Display menu and handle user input
            // Options should include:
            // 1. Add Product
            // 2. Remove Product
            // 3. Update Quantity
            // 4. Find Product
            // 5. View All Products
            // 6. Generate Reports
            // 7. Check Low Stock
            // 8. Exit
            
            while (true)
            {
                DisplayMenu();
                string choice = Console.ReadLine();
                
                switch (choice)
                {
                    case "1":
                        AddProductMenu();
                        break;
                    case "2":
                        RemoveProductMenu();
                        break;
                    // TODO: Implement other cases
                    case "3":
                        UpdateQuantity();
                        break;
                    case "8":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }
        
        static void DisplayMenu()
        {
            // TODO: Display formatted menu
            throw new NotImplementedException();
        }
        
        static void AddProductMenu()
        {
            // TODO: Implement menu to add different product types
            // Ask user for product type
            // Collect appropriate properties
            // Add to inventory
            throw new NotImplementedException();
        }
        
        static void RemoveProductMenu()
        {
            // TODO: Implement product removal
            throw new NotImplementedException();
        }
        
        // TODO: Add other menu methods
    }
}
*/
using System;
using FlexibleInventorySystem.Models;
using FlexibleInventorySystem.Services;
using FlexibleInventorySystem.Utilities;

namespace FlexibleInventorySystem
{
    class Program
    {
        private static InventoryManager _inventory = new InventoryManager();

        static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();
                Console.Write("Select option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddProductMenu();
                        break;
                    case "2":
                        RemoveProductMenu();
                        break;
                    case "3":
                        UpdateQuantityMenu();
                        break;
                    case "4":
                        FindProductMenu();
                        break;
                    case "5":
                        Console.WriteLine(_inventory.GenerateInventoryReport());
                        break;
                    case "6":
                        Console.WriteLine(_inventory.GenerateCategorySummary());
                        break;
                    case "7":
                        Console.WriteLine(_inventory.GenerateValueReport());
                        break;
                    case "8":
                        ExpiryReportMenu();
                        break;
                    case "9":
                        LowStockMenu();
                        break;
                    case "10":
                        return;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }

                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }

        static void DisplayMenu()
        {
            Console.Clear();
            Console.WriteLine("==================================");
            Console.WriteLine(" FLEXIBLE INVENTORY SYSTEM");
            Console.WriteLine("==================================");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Update Quantity");
            Console.WriteLine("4. Find Product");
            Console.WriteLine("5. Inventory Report");
            Console.WriteLine("6. Category Summary");
            Console.WriteLine("7. Value Analysis Report");
            Console.WriteLine("8. Expiry Report");
            Console.WriteLine("9. Low Stock Products");
            Console.WriteLine("10. Exit");
            Console.WriteLine("==================================");
        }

        static void AddProductMenu()
        {
            Console.WriteLine("Select Product Type:");
            Console.WriteLine("1. Electronic");
            Console.WriteLine("2. Grocery");
            Console.WriteLine("3. Clothing");

            string typeChoice = Console.ReadLine();

            Console.Write("ID: ");
            string id = Console.ReadLine();

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Category: ");
            string category = Console.ReadLine();

            Console.Write("Price: ");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.Write("Quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product = null;

            switch (typeChoice)
            {
                case "1":
                    product = CreateElectronic(id, name, category, price, quantity);
                    break;
                case "2":
                    product = CreateGrocery(id, name, category, price, quantity);
                    break;
                case "3":
                    product = CreateClothing(id, name, category, price, quantity);
                    break;
            }

            if (product != null)
            {
                if (_inventory.AddProduct(product))
                    Console.WriteLine("Product added successfully.");
                else
                    Console.WriteLine("Failed to add product.");
            }
        }

        static ElectronicProduct CreateElectronic(string id, string name, string category, decimal price, int quantity)
        {
            Console.Write("Brand: ");
            string brand = Console.ReadLine();

            Console.Write("Warranty (months): ");
            int warranty = int.Parse(Console.ReadLine());

            Console.Write("Voltage: ");
            string voltage = Console.ReadLine();

            return new ElectronicProduct
            {
                Id = id,
                Name = name,
                Category = category,
                Price = price,
                Quantity = quantity,
                Brand = brand,
                WarrantyMonths = warranty,
                Voltage = voltage
            };
        }

        static GroceryProduct CreateGrocery(string id, string name, string category, decimal price, int quantity)
        {
            Console.Write("Expiry Date (yyyy-mm-dd): ");
            DateTime expiry = DateTime.Parse(Console.ReadLine());

            Console.Write("Is Perishable (true/false): ");
            bool perishable = bool.Parse(Console.ReadLine());

            Console.Write("Weight: ");
            double weight = double.Parse(Console.ReadLine());

            Console.Write("Storage Temperature: ");
            string storage = Console.ReadLine();

            return new GroceryProduct
            {
                Id = id,
                Name = name,
                Category = category,
                Price = price,
                Quantity = quantity,
                ExpiryDate = expiry,
                IsPerishable = perishable,
                Weight = weight,
                StorageTemperature = storage
            };
        }

        static ClothingProduct CreateClothing(string id, string name, string category, decimal price, int quantity)
        {
            Console.Write("Size: ");
            string size = Console.ReadLine();

            Console.Write("Color: ");
            string color = Console.ReadLine();

            Console.Write("Material: ");
            string material = Console.ReadLine();

            Console.Write("Gender: ");
            string gender = Console.ReadLine();

            Console.Write("Season: ");
            string season = Console.ReadLine();

            return new ClothingProduct
            {
                Id = id,
                Name = name,
                Category = category,
                Price = price,
                Quantity = quantity,
                Size = size,
                Color = color,
                Material = material,
                Gender = gender,
                Season = season
            };
        }

        static void RemoveProductMenu()
        {
            Console.Write("Enter Product ID to remove: ");
            string id = Console.ReadLine();

            if (_inventory.RemoveProduct(id))
                Console.WriteLine("Product removed.");
            else
                Console.WriteLine("Product not found.");
        }

        static void UpdateQuantityMenu()
        {
            Console.Write("Enter Product ID: ");
            string id = Console.ReadLine();

            Console.Write("New Quantity: ");
            int qty = int.Parse(Console.ReadLine());

            if (_inventory.UpdateQuantity(id, qty))
                Console.WriteLine("Quantity updated.");
            else
                Console.WriteLine("Update failed.");
        }

        static void FindProductMenu()
        {
            Console.Write("Enter Product ID: ");
            string id = Console.ReadLine();

            var product = _inventory.FindProduct(id);

            if (product != null)
                Console.WriteLine(product.GetProductDetails());
            else
                Console.WriteLine("Product not found.");
        }

        static void ExpiryReportMenu()
        {
            Console.Write("Enter days threshold: ");
            int days = int.Parse(Console.ReadLine());

            Console.WriteLine(_inventory.GenerateExpiryReport(days));
        }

        static void LowStockMenu()
        {
            Console.Write("Enter threshold: ");
            int threshold = int.Parse(Console.ReadLine());

            var lowStock = _inventory.GetLowStockProducts(threshold);

            foreach (var product in lowStock)
            {
                Console.WriteLine($"{product.Name} - Qty: {product.Quantity}");
            }
        }
    }
}


