using System;
using System.Linq;

namespace FlexibleInventorySystem.Models
{
    /// <summary>
    /// TODO: Implement clothing product class
    /// </summary>
    public class ClothingProduct : Product
    {
        // TODO: Add these properties
        // - Size (string)
        // - Color (string)
        // - Material (string)
        // - Gender (string) - "Men", "Women", "Unisex"
        // - Season (string) - "Summer", "Winter", "All-season"
        public string Size { get; set; }
        public string Color { get; set; }
        public string Material { get; set; }
        public string Gender { get; set; }
        public string Season { get; set; }
        
        /// <summary>
        /// TODO: Override GetProductDetails for clothing items
        /// </summary>
        public override string GetProductDetails()
        {
            // TODO: Return formatted string with size, color, material
            return $"Name:{Name} | Size:{Size} | Color:{Color} | Material:{Material}";
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Check if size is available
        /// Valid sizes: XS, S, M, L, XL, XXL
        /// </summary>
        public bool IsValidSize()
        {
            // TODO: Validate size against allowed values
            string[] sizes = {"XS", "S", "M", "L", "XL", "XXL"};
            return sizes.Contains(Size?.ToUpper());
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Override CalculateValue to apply seasonal discount
        /// Apply 15% discount for off-season items
        /// </summary>
        public override decimal CalculateValue()
        {
            // TODO: Apply seasonal discount logic
            if ((IsOffSeason()))
            {
                return base.CalculateValue() * 0.85m;
            }
            else return base.CalculateValue();
            // throw new NotImplementedException();
        }
        private bool IsOffSeason()
        {
            if(string.Equals(Season, "All-season", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            string current;
            int month = DateTime.Now.Month;
            current = (month >= 3 && month <= 10)?"summer":"winter";
            return !string.Equals(Season, current, StringComparison.OrdinalIgnoreCase);
        }
    }
}
