using System;
using System.Collections.Generic;
using System.Linq;
using FlexibleInventorySystem.Interfaces;
using FlexibleInventorySystem.Models;

namespace FlexibleInventorySystem.Services
{
    /// <summary>
    /// TODO: Implement main inventory manager class
    /// This class should implement both IInventoryOperations and IReportGenerator
    /// </summary>
    public class InventoryManager : IInventoryOperations, IReportGenerator
    {
        // TODO: Declare a private List<Product> to store products
        // TODO: Add a thread-safety lock object (optional)
        private List<Product> _products;
        public InventoryManager()
        {
            // TODO: Initialize the products list
            _products = new List<Product>();
        }
        
        // ============ IInventoryOperations Implementation ============
        
        /// <summary>
        /// TODO: Add a product to inventory
        /// Rules:
        /// - Product cannot be null
        /// - Product ID must be unique
        /// - Price must be positive
        /// - Quantity cannot be negative
        /// </summary>
        public bool AddProduct(Product product)
        {
            // TODO: Validate product
            // TODO: Check for duplicate ID
            // TODO: Add to collection
            // TODO: Return true if successful
            
            if (product == null)
                return false;

            if (product.Price <= 0)
                return false;

            if (product.Quantity < 0)
                return false;

            if (_products.Any(p => p.Id == product.Id))
                return false;

            _products.Add(product);
            return true;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Remove product by ID
        /// Return false if product not found
        /// </summary>
        public bool RemoveProduct(string productId)
        {
            // TODO: Find and remove product
            var product = _products.FirstOrDefault(p => p.Id == productId);
            if (product == null)
                return false;

            _products.Remove(product);
            return true;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Find product by ID
        /// Return null if not found
        /// </summary>
        public Product FindProduct(string productId)
        {
            // TODO: Search and return product
            return _products.Find(p=>p.Id == productId);
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Get all products in a specific category
        /// Use case-insensitive comparison
        /// </summary>
        public List<Product> GetProductsByCategory(string category)
        {
            // TODO: Filter products by category
            return _products.Where(p=>String.Equals(p.Category, category, StringComparison.OrdinalIgnoreCase)).ToList();
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Update product quantity
        /// Rules:
        /// - Quantity cannot be negative
        /// - Return false if product not found
        /// - Return false if new quantity is invalid
        /// </summary>
        public bool UpdateQuantity(string productId, int newQuantity)
        {
            // TODO: Validate and update quantity
            if(newQuantity < 0)
            {
                return false;
            }
            var product = _products.FirstOrDefault(p=>p.Id == productId);
            if(product == null)
            {
                return false;
            }
            product.Quantity = newQuantity;
            return true;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Calculate total value of all products
        /// Use CalculateValue() method of each product
        /// </summary>
        public decimal GetTotalInventoryValue()
        {
            // TODO: Sum up all product values
            return _products.Sum(p => p.CalculateValue());
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Get products with quantity below threshold
        /// </summary>
        public List<Product> GetLowStockProducts(int threshold)
        {
            // TODO: Filter products with Quantity < threshold
            return _products.Where(p=>p.Quantity < threshold).ToList();
            // throw new NotImplementedException();
        }
        
        // ============ IReportGenerator Implementation ============
        
        /// <summary>
        /// TODO: Generate complete inventory report
        /// Format:
        /// ================================
        /// INVENTORY REPORT
        /// ================================
        /// Total Products: {count}
        /// Total Value: {value:C}
        /// 
        /// Product List:
        /// {For each product: Id - Name - Category - Quantity - Value:C}
        /// </summary>
        public string GenerateInventoryReport()
        {
            // TODO: Build formatted report
            var report = new System.Text.StringBuilder();
            report.AppendLine("================================");
            report.AppendLine("INVENTORY REPORT");
            report.AppendLine("================================");

            int totalProducts = _products.Count;
            decimal totalValue = _products.Sum(p => p.CalculateValue());

            report.AppendLine($"Total Products: {totalProducts}");
            report.AppendLine($"Total Value: {totalValue:C}");
            report.AppendLine();
            report.AppendLine("Product List:");

            foreach (var product in _products)
            {
                report.AppendLine(
                    $"{product.Id} - {product.Name} - {product.Category} - Qty: {product.Quantity} - Value: {product.CalculateValue():C}"
                );
            }

            return report.ToString();
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Generate category-wise summary
        /// Format:
        /// CATEGORY SUMMARY
        /// {Category1}: {count} items - Total Value: {value:C}
        /// {Category2}: {count} items - Total Value: {value:C}
        /// </summary>
        public string GenerateCategorySummary()
        {
            // TODO: Group by category and summarize
            var groupedProduct = _products.GroupBy(p=>p.Category, StringComparer.OrdinalIgnoreCase);
            var summary = new System.Text.StringBuilder();
            summary.AppendLine("CATEGORY SUMMARY");
            foreach(var group in groupedProduct)
            {
                summary.AppendLine($" {group.Key}: {group.Sum(p=>p.Quantity)} items - Total Value: {group.Sum(p=>p.CalculateValue()):C}");
            }
            return summary.ToString();
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Generate value analysis report
        /// Include:
        /// - Most valuable product
        /// - Least valuable product
        /// - Average price
        /// - Median price
        /// - Products above average price
        /// </summary>
        public string GenerateValueReport()
        {
            // TODO: Calculate statistics
            if (!_products.Any())
            {
                return "No products available for analysis.";
            }
            var mostValuableProduct = _products.MaxBy(p=>p.CalculateValue());
            var leastValuableProduct = _products.MinBy(p=>p.CalculateValue());
            var averagePrice = _products.Average(p=>p.Price);

            var orderedPrices = _products
                .Select(p => p.Price)
                .OrderBy(p => p)
                .ToList();

            decimal medianPrice;

            int count = orderedPrices.Count;

            if (count % 2 == 0)
            {
                medianPrice = (orderedPrices[count / 2 - 1] + orderedPrices[count / 2]) / 2;
            }
            else
            {
                medianPrice = orderedPrices[count / 2];
            }
            var aboveAvgPriceProduct = _products.Where(p=>p.Price > averagePrice).ToList();

            var report = new System.Text.StringBuilder;

            report.AppendLine("VALUE ANALYSIS REPORT");
            report.AppendLine("--------------------------------");
            report.AppendLine($"Most Valuable Product: {mostValuableProduct.Name} - {mostValuableProduct.CalculateValue():C}");
            report.AppendLine($"Least Valuable Product: {leastValuableProduct.Name} - {leastValuableProduct.CalculateValue():C}");
            report.AppendLine($"Average Price: {averagePrice:C}");
            report.AppendLine($"Median Price: {medianPrice:C}");
            report.AppendLine();
            report.AppendLine("Products Above Average Price:");

            foreach (var product in aboveAvgPriceProduct)
            {
                report.AppendLine($"{product.Name} - {product.Price:C}");
            }

            return report.ToString();

            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Generate report of expiring grocery products
        /// Include products expiring within daysThreshold
        /// </summary>
        public string GenerateExpiryReport(int daysThreshold)
        {
            // TODO: Find expiring grocery products
            var expiringProducts = _products.OfType<GroceryProduct>()
                            .Where(p=>!p.IsExpired() && p.DaysUntilExpiry() <= daysThreshold)
                            .ToList();
            var report = new System.Text.StringBuilder();
            report.AppendLine("EXPIRY REPORT");
            report.AppendLine("--------------------------------");
            if (!expiringProducts.Any())
            {
                report.AppendLine("No grocery products expiring within threshold.");
                return report.ToString();
            }

            foreach (var product in expiringProducts)
            {
                report.AppendLine(
                    $"{product.Name} - Expires in {product.DaysUntilExpiry()} days - Qty: {product.Quantity}"
                );
            }

            return report.ToString();
            // throw new NotImplementedException();
        }
        
        // ============ Additional Methods (Optional) ============
        
        /// <summary>
        /// TODO (Bonus): Search products with custom criteria
        /// </summary>
        public IEnumerable<Product> SearchProducts(Func<Product, bool> predicate)
        {
            // TODO: Implement custom search
            
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO (Bonus): Apply discount to products in category
        /// </summary>
        public void ApplyCategoryDiscount(string category, decimal discountPercentage)
        {
            // TODO: Apply discount to all products in category
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO (Bonus): Get total count of products
        /// </summary>
        public int GetTotalProductCount()
        {
            // TODO: Return total number of products
            throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO (Bonus): Get unique categories
        /// </summary>
        public IEnumerable<string> GetCategories()
        {
            // TODO: Return distinct categories
            throw new NotImplementedException();
        }
    }
}

