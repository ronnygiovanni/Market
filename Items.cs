public class Items
{
    // 2.3 Metoda pentru cel mai bun client
    public string GetBestCustomer(List<Order> orders)
    {
        return orders
            .GroupBy(o => o.CustomerName)
            .Select(g => new { Name = g.Key, TotalSpent = g.Sum(o => o.GetFinalPrice()) })
            .OrderByDescending(x => x.TotalSpent)
            .First()
            .Name;
    }

    // 2.4 Metoda pentru produse populare
    public Dictionary<string, int> GetPopularProducts(List<Order> orders)
    {
        return orders
            .SelectMany(o => o.OrderProducts)
            .GroupBy(i => i.ProductName)
            .ToDictionary(g => g.Key, g => g.Sum(i => i.Quantity));
    }
}