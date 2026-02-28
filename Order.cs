public class Order
{
    public string CustomerName;
    public List<OrderItem> OrderProducts;

    public Order(string customerName)
    {
        this.CustomerName = customerName;
        this.OrderProducts = new List<OrderItem>();
    }

    public decimal GetFinalPrice()
    {
        decimal total = OrderProducts.Sum(item => item.Quantity * item.UnitPrice);
        
        if (total > 500)
        {
            return total * 0.9m; 
        }
        return total;
    }
}