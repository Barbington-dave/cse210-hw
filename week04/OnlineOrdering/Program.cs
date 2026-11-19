using System;

class Program
{
    static void Main(string[] args)
    {
 
        Address address1 = new Address("742 Evergreen Terrace", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Sarah Jenkins", address1);
        Order order1 = new Order(customer1);

        order1.AddProduct(new Product("Wireless Mechanical Keyboard", "KB-104", 79.99, 1));
        order1.AddProduct(new Product("Ergonomic Mouse", "MS-208", 34.50, 1));
        order1.AddProduct(new Product("USB-C Braided Cable", "CB-312", 12.00, 2));

        Address address2 = new Address("14 Meridian Avenue", "Tema", "Greater Accra", "Ghana");
        Customer customer2 = new Customer("David Inkoom", address2);
        Order order2 = new Order(customer2);

        order2.AddProduct(new Product("Noise-Cancelling Headphones", "HP-501", 149.99, 1));
        order2.AddProduct(new Product("Laptop Stand", "LS-119", 29.95, 2));

        List<Order> orders = new List<Order> { order1, order2 };

        int orderNumber = 1;
        foreach (Order order in orders)
        {
            Console.WriteLine("========================================");
            Console.WriteLine($"ORDER #{orderNumber}");
            Console.WriteLine("========================================");
            Console.WriteLine(order.GetPackingLabel());
            Console.WriteLine(order.GetShippingLabel());
            Console.WriteLine($"\nTotal Price: ${order.CalculateTotalCost():F2}");
            Console.WriteLine();
            orderNumber++;
        }
    }
}