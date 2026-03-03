namespace MvcCoreWebAppDemo1.Models
{
    public class ProductRepo
    {
        public List<Product> prodList = new List<Product>();

        public ProductRepo()
        {
            // Hard-coded sample products; images served from wwwroot/images
            prodList.AddRange(new List<Product>
            {
                new Product { ProuctId = 1, Name = "Hydrating Face Cream", cost = 499.00m, ImageUrl = "~/images/product1.jpg" },
                new Product { ProuctId = 2, Name = "Vitamin C Serum", cost = 799.00m, ImageUrl = "~/images/product2.jpg" },
                new Product { ProuctId = 3, Name = "Gentle Cleanser", cost = 299.00m, ImageUrl = "~/images/product3.jpg" },
                new Product { ProuctId = 4, Name = "Sunscreen SPF 50", cost = 599.00m, ImageUrl = "~/images/product4.jpg" },
                new Product { ProuctId = 5, Name = "Night Repair Cream", cost = 899.00m, ImageUrl = "~/images/product5.jpg" },
                new Product { ProuctId = 6, Name = "Lip Balm", cost = 149.00m, ImageUrl = "~/images/product6.jpg" },
                new Product { ProuctId = 7, Name = "Body Lotion", cost = 399.00m, ImageUrl = "~/images/product7.jpg" },
                new Product { ProuctId = 8, Name = "Hair Serum", cost = 649.00m, ImageUrl = "~/images/product8.jpg" },
                new Product { ProuctId = 9, Name = "Face Toner", cost = 349.00m, ImageUrl = "~/images/product9.jpg" },
                new Product { ProuctId = 10, Name = "Under Eye Cream", cost = 549.00m, ImageUrl = "~/images/product10.jpg" },
                new Product { ProuctId = 11, Name = "Clay Mask", cost = 449.00m, ImageUrl = "~/images/product11.jpg" },
                new Product { ProuctId = 12, Name = "Sheet Mask", cost = 199.00m, ImageUrl = "~/images/product12.jpg" },
                new Product { ProuctId = 13, Name = "Face Scrub", cost = 329.00m, ImageUrl = "~/images/product13.jpg" },
                new Product { ProuctId = 14, Name = "Hand Cream", cost = 249.00m, ImageUrl = "~/images/product14.jpg" },
                new Product { ProuctId = 15, Name = "Foot Cream", cost = 269.00m, ImageUrl = "~/images/product15.jpg" },
                new Product { ProuctId = 16, Name = "Makeup Remover", cost = 379.00m, ImageUrl = "~/images/product16.jpg" },
                new Product { ProuctId = 17, Name = "BB Cream", cost = 559.00m, ImageUrl = "~/images/product17.jpg" },
                new Product { ProuctId = 18, Name = "Compact Powder", cost = 499.00m, ImageUrl = "~/images/product18.jpg" },
                new Product { ProuctId = 19, Name = "Blush Palette", cost = 699.00m, ImageUrl = "~/images/product19.jpg" },
                new Product { ProuctId = 20, Name = "Highlighter", cost = 649.00m, ImageUrl = "~/images/product20.jpg" }
            });
        }

        public List<Product> GetAllCosmeticProducts()
        {
            return prodList;
        }
    }
}
