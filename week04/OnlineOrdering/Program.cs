using System;

class Program
{
    static void Main(string[] args)
    {
        // Order 1 (USA)
        Address address1 = new Address("123 Street", "New York", "NY", "USA");
        Customer customer1 = new Customer("John Doe", address1);

        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "P001", 1000, 1));
        order1.AddProduct(new Product("Mouse", "P002", 50, 2));

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order1.GetTotalCost()}");

        Console.WriteLine();

        // Order 2 (International)
        Address address2 = new Address("45 Road", "Lagos", "LA", "Nigeria");
        Customer customer2 = new Customer("Chisom", address2);

        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Phone", "P003", 500, 1));
        order2.AddProduct(new Product("Charger", "P004", 20, 3));

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Cost: ${order2.GetTotalCost()}");
    }
}