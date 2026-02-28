class Program
{
    static void Main()
    {
   
        var o1 = new Order("Andrei");
        o1.OrderProducts.Add(new OrderItem("Laptop", 1, 1200));
        o1.OrderProducts.Add(new OrderItem("Mouse", 7, 25));

        var o2 = new Order("Maria");
        o2.OrderProducts.Add(new OrderItem("Keyboard", 1, 100));

        var o3 = new Order("Mihai");
        o3.OrderProducts.Add(new OrderItem("Mouse", 3, 25));

        var o4 = new Order("Ronny");
        o4.OrderProducts.Add(new OrderItem("PC", 3, 5000));

    
        List<Order> orders = new List<Order> { o1, o2, o3, o4 };

      
        foreach (var order in orders)
        {
            Console.WriteLine($"Client: {order.CustomerName} | Total: {order.GetFinalPrice()}€");
        }

        Items calculator = new Items();

  
        string bestCustomerName = calculator.GetBestCustomer(orders);
        Console.WriteLine($"\nCel mai bun client: {bestCustomerName}");

     
        var popular = calculator.GetPopularProducts(orders);
        Console.WriteLine("\nProduse Populare:");
        foreach (var p in popular)
        {
            if (p.Value > 1)
            {
                Console.WriteLine($"{p.Key}: {p.Value} unitati");
            }
        }

    }
}