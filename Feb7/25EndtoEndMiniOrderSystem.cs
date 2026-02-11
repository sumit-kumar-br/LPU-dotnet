class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
}
class Product
{
    public int PorductID { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Stock { get; set; }
}
class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal TotalPrice => Product.Price * Quantity;
}
class Order
{
    public int OrderID { get; set; }
    public int CustomerID { get; set; }
    public List<OrderItem> Items { get; set; } = new();
    public decimal Discount { get; set; }
    public decimal TotalAmount { get; set; }
    public string InvoiceNumber { get; set; }
}
class Payment
{
    public string PaymentId { get; set; }
    public decimal Amount { get; set; }
    public bool IsSuccessful { get; set; }
}
class OutOfStockException : Exception
{
    public OutOfStockException(string message): base(message) { }
}
class PaymentFailedException: Exception
{
    public PaymentFailedException(string message): base(message) { }
}
class InvalidCouponException: Exception
{
    public InvalidCouponException(string message): base(message) { }  
}
class OrderService
{
    public void AddToCart(Order order, Product product, int quantity)
    {
        if(quantity <= 0)
        {
            throw new ArgumentException("Quantity must be greater than zero");
        }
        order.Items.Add(new OrderItem
        {
            Product = product,
            Quantity = quantity,
        });
    }

    public void ApplyCoupon(Order order, string couponCode)
    {
        if(couponCode == "SAVE10")
        {
            order.Discount = order.Items.Sum(s=>s.TotalPrice * 0.10m);
        }
        else
        {
            throw new InvalidCouponException("Invalid Coupon Code!!");
        }
    }
    public string GenerateInvoice()
    {
        return $"INV-{DateTime.Now}";
    }
    public Order PlaceOrder(Order order)
    {
        foreach(var item in order.Items)
        {
            if(item.Product.Stock < item.Quantity)
            {
                throw new OutOfStockException(
                    $"Product {item.Product.Name} is out of stock"
                );
            }
        }
        foreach(var item in order.Items)
        {
            item.Product.Stock -= item.Quantity;        
        }
    }
    decimal subTotal = order.Items.Sum(i => i.TotalPrice);
    order.TotalAmount =  

}