using System;
using OnlineOrdering;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Address address1 = new Address("123 Elm St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Dan", address1);
        Order order1 = new Order(customer1);

        Product product1 = new Product("Wireless Mouse", "M102", 25.50, 2);
        Product product2 = new Product("Mechanical Keyboard", "K405", 79.99, 1);
        Product product3 = new Product("HDMI", "C992", 12.00, 3);

        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        Address address2 = new Address("456 Rue de Rivoli", "Paris", "Ile-de-France", "France");
        Customer customer2 = new Customer("Amélie Poulenne", address2);
        Order order2 = new Order(customer2);

        Product product4 = new Product("USB-C Hub", "H112", 45.00, 1);
        Product product5 = new Product("Monitor Mount", "B881", 35.50, 2);

        order2.AddProduct(product4);
        order2.AddProduct(product5);

        Console.WriteLine("=============================");
        Console.WriteLine("ORDER 1 DETAILS");
        Console.WriteLine("=============================");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order1.CalculateTotalOrderCost():F2}\n");

        Console.WriteLine("=============================");
        Console.WriteLine("ORDER 2 DETAILS");
        Console.WriteLine("=============================");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Order Cost: ${order2.CalculateTotalOrderCost():F2}\n");
    }
}