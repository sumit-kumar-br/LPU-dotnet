using ProductApi.Models;

namespace ProductApi.Data
{
    public class ProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product{Id=1,Name="Laptop",Price=50000,Quantity=10},
            new Product{Id=2,Name="Mouse",Price=500,Quantity=50}
        };

        public List<Product> GetAll()
        {
            return products;
        }

        public Product GetById(int id)
        {
            return products.FirstOrDefault(x => x.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = products.Max(x => x.Id) + 1;
            products.Add(product);
        }

        public void Update(Product product)
        {
            var data = products.FirstOrDefault(x => x.Id == product.Id);

            data.Name = product.Name;
            data.Price = product.Price;
            data.Quantity = product.Quantity;
        }

        public void Delete(int id)
        {
            var product = products.FirstOrDefault(x => x.Id == id);
            products.Remove(product);
        }
    }
}