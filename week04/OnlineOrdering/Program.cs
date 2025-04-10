using System;

class Program
{
    static void Main(string[] args)
    {
        // Create addresses
        Address usaAddress = new Address("123 Main St", "New York", "NY", "USA");
        Address ghanaAddress = new Address("65BLK EI", "Kumasi", "KSI", "Ghana");

        // Create customers
        Customer customer1 = new Customer("John Smith", usaAddress);
        Customer customer2 = new Customer("Kofi Owusu Ansah", ghanaAddress);

        // Create products
        Product product1 = new Product("Laptop", "P100", 999.99, 1);
        Product product2 = new Product("Mouse", "P101", 19.99, 2);
        Product product3 = new Product("Keyboard", "P102", 49.99, 1);
        Product product4 = new Product("Monitor", "P103", 199.99, 2);
        Product product5 = new Product("Soundbar", "P105", 1199.99,2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Display order information
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalculateTotalCost():0.00}\n");

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalculateTotalCost():0.00}\n");
    }
}