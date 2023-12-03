using System;

class Program
{
    static void Main(string[] args)
    {
        List<Product> productsOne = new List<Product>();
        Address addressOne = new Address("123 Main Street", "Springfield", "CA", "USA");
        Customer customerOne = new Customer("Emily Johnson", addressOne);
    
        productsOne.Add(new Product("Fuzzy Socks", 736824, 4.50, 4));
        productsOne.Add(new Product("Banana", 219506, 0.35, 6));
        productsOne.Add(new Product("Chapstick", 490175, 2.50, 3));

        Order OrderOne = new Order(productsOne, customerOne);

        OrderOne.GetShippingLabel();
        OrderOne.GetPackingLabel();
        Console.WriteLine($"Order total: ${OrderOne.TotalCost()}\n");

        List<Product> productsTwo = new List<Product>();
        Address addressTwo = new Address("456 Maple Lane", "Toronto", "Ontario", "Canada");
        Customer customerTwo = new Customer("Daniel Smith", addressTwo);
        
        productsTwo.Add(new Product("Water Bottle", 821309, 24.00, 1));
        productsTwo.Add(new Product("Laptop Stand", 604732, 14.80, 3));
        productsTwo.Add(new Product("Battery Pack", 158943, 9.95, 7));

        Order OrderTwo = new Order(productsTwo, customerTwo);

        OrderTwo.GetShippingLabel();
        OrderTwo.GetPackingLabel();
        Console.WriteLine($"Order total: ${OrderTwo.TotalCost()}\n");
    }
}