namespace MvcCoreWebAppDemo1.Models
{
    public class CartRepo
    {
        private readonly Cart _cart = new Cart();
        private readonly ProductRepo _productRepo = new ProductRepo();

        public Cart GetCart()
        {
            return _cart;
        }

        public void AddToCart(int productId, int quantity = 1)
        {
            var product = _productRepo.prodList.FirstOrDefault(p => p.ProuctId == productId);
            if (product == null) return;

            var existing = _cart.Items.FirstOrDefault(i => i.ProductId == productId);
            if (existing == null)
            {
                _cart.Items.Add(new CartItem
                {
                    ProductId = productId,
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                existing.Quantity += quantity;
            }
        }

        public void RemoveFromCart(int productId)
        {
            var existing = _cart.Items.FirstOrDefault(i => i.ProductId == productId);
            if (existing != null)
            {
                _cart.Items.Remove(existing);
            }
        }

        public void ClearCart()
        {
            _cart.Items.Clear();
        }
    }
}