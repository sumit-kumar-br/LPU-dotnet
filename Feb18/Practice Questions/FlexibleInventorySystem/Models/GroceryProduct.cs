using System;

namespace FlexibleInventorySystem.Models
{
    /// <summary>
    /// TODO: Implement grocery product class
    /// </summary>
    public class GroceryProduct : Product
    {
        // TODO: Add these properties
        // - ExpiryDate (DateTime)
        // - IsPerishable (bool)
        // - Weight (double)
        // - StorageTemperature (string) - e.g., "Room temperature", "Refrigerated", "Frozen"
        public DateTime ExpiryDate { get; set; }
        public bool IsPerishable { get; set; }
        public double Weight { get; set; }
        public string StorageTemperature { get; set; }
        
        /// <summary>
        /// TODO: Override GetProductDetails for grocery items
        /// Include expiry information
        /// </summary>
        public override string GetProductDetails()
        {
            // TODO: Implement
            string status = IsExpired() ? "Expired": $"Expires in {DaysUntilExpiry()} days";
            return $"Name: {Name} | Expiry: {ExpiryDate:dd-MM-yyyy} | {status} | Weight: {Weight}kg | Storage: {StorageTemperature}";;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Check if product is expired
        /// </summary>
        public bool IsExpired()
        {
            // TODO: Compare ExpiryDate with current date
            return DateTime.Today > ExpiryDate.Date;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Calculate days until expiry
        /// Return negative if expired
        /// </summary>
        public int DaysUntilExpiry()
        {
            // TODO: Calculate days difference
            return (ExpiryDate - DateTime.Today).Days;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Override CalculateValue to apply discount for near-expiry items
        /// Apply 20% discount if within 3 days of expiry
        /// </summary>
        public override decimal CalculateValue()
        {
            // TODO: Apply discount logic if near expiry
            if(!IsExpired() && DaysUntilExpiry() <= 3)
            {
                return base.CalculateValue() * 0.80m;
            }
            return base.CalculateValue();
            // throw new NotImplementedException();
        }
    }
}
