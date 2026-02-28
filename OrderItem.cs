public class OrderItem
{
    public string ProductName;
    public int Quantity;
    public decimal UnitPrice;

    public OrderItem(string productName, int quantity, decimal unitPrice)
    {
        this.ProductName = productName;
        this.Quantity = quantity;
        this.UnitPrice = unitPrice;
    }
}