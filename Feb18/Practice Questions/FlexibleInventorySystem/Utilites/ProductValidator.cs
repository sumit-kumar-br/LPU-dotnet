using FlexibleInventorySystem.Models;

namespace FlexibleInventorySystem.Utilities
{
    /// <summary>
    /// TODO: Implement validation helper class
    /// </summary>
    public static class ProductValidator
    {
        /// <summary>
        /// TODO: Validate product data
        /// Check:
        /// - ID not null/empty
        /// - Name not null/empty
        /// - Price > 0
        /// - Quantity >= 0
        /// </summary>
        public static bool ValidateProduct(Product product, out string errorMessage)
        {
            // TODO: Implement validation
            errorMessage = null;
            if(product == null)
            {
                errorMessage = "Product cannot be null";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Id))
            {
                errorMessage = "Product Id cannot be empty";
                return false;
            }
            if (string.IsNullOrWhiteSpace(product.Name))
            {
                errorMessage = "Product Name must not be empty";
                return false;
            }
            if(product.Price <= 0)
            {
                errorMessage = "Price cannot be negative";
                return false;
            }
            if(product.Quantity < 0)
            {
                errorMessage = "Quantity cannot be negative";
                return false;   
            }
            return true;
            
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Validate electronic product specific rules
        /// </summary>
        public static bool ValidateElectronicProduct(ElectronicProduct product, out string errorMessage)
        {
            // TODO: Implement electronic validation
            errorMessage = null;

            if (!ValidateProduct(product, out errorMessage))
                return false;

            if (string.IsNullOrWhiteSpace(product.Brand))
            {
                errorMessage = "Brand is required.";
                return false;
            }

            if (product.WarrantyMonths < 0)
            {
                errorMessage = "Warranty months cannot be negative.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Voltage))
            {
                errorMessage = "Voltage specification is required.";
                return false;
            }

            return true;
        
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Validate grocery product specific rules
        /// </summary>
        public static bool ValidateGroceryProduct(GroceryProduct product, out string errorMessage)
        {
            // TODO: Implement grocery validation
            errorMessage = null;

            if (!ValidateProduct(product, out errorMessage))
                return false;

            if (product.ExpiryDate == default)
            {
                errorMessage = "Expiry date must be specified.";
                return false;
            }

            if (product.Weight <= 0)
            {
                errorMessage = "Weight must be greater than zero.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.StorageTemperature))
            {
                errorMessage = "Storage temperature is required.";
                return false;
            }

            return true;
            // throw new NotImplementedException();
        }
        
        /// <summary>
        /// TODO: Validate clothing product specific rules
        /// </summary>
        public static bool ValidateClothingProduct(ClothingProduct product, out string errorMessage)
        {
            // TODO: Implement clothing validation
            errorMessage = null;
            if (!ValidateProduct(product, out errorMessage))
                return false;

            if (string.IsNullOrWhiteSpace(product.Size))
            {
                errorMessage = "Size is required.";
                return false;
            }

            if (!product.IsValidSize())
            {
                errorMessage = "Invalid size. Allowed sizes: XS, S, M, L, XL, XXL.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Color))
            {
                errorMessage = "Color is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Material))
            {
                errorMessage = "Material is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(product.Season))
            {
                errorMessage = "Season is required.";
                return false;
            }

            return true;
            // throw new NotImplementedException();
        }
    }
}
