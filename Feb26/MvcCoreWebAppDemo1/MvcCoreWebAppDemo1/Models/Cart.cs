namespace MvcCoreWebAppDemo1.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
    public class Cart
    {
        public List<CartItem> Items { get; set; } = new List<CartItem>();

        public decimal TotalCost => Items.Sum(item => item.Product.cost * item.Quantity);
    }
}
