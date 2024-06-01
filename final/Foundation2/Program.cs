using System;

class Program
{
    static void Main(string[] args)
    {

        Product product1 = new Product("Milk", 3.99, 1, 2);
        Product product2 = new Product("Eggs", 1.99, 2, 1);
        Product product3 = new Product("Cheese", 5.99, 3, 5);
        Product product4 = new Product("Cereal", 4.99, 4, 3);
        Product product5 = new Product("Yogurt", 2.99, 5, 4);
        
        Address address1 = new Address("123 Main St", "New York", "NY", "USA");
        Customer customer1 = new Customer("Kaleb Cote", address1);
        
        Order order1 = new Order(customer1, new List<Product> { product1, product2, product3 });
        Console.WriteLine(order1.PackingLabel());
        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.CalculateTotal(customer1));
        Console.WriteLine();

        Address address2 = new Address("456 Main St", "Sao Paulo", "SP", "BR");
        Customer customer2 = new Customer("Laura Puerta", address2);

        Order order2 = new Order(customer2, new List<Product> { product4, product5 });
        Console.WriteLine(order2.PackingLabel());
        Console.WriteLine(order2.ShippingLabel());
        Console.WriteLine(order2.CalculateTotal(customer2));


    }
}