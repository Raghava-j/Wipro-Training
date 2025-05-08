using System;
using System.Collections.Generic;

class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product { ID = 1, Name = "Laptop", Price = 75000},
            new Product { ID = 2, Name = "Smartphone", Price = 30000},
            new Product { ID = 3, Name = "Headphones", Price = 5000},
            new Product { ID = 4, Name = "Monitor", Price = 15000},
            new Product { ID = 5, Name = "Keyboard", Price = 2000}
        };
        products.Sort((p1, p2) => p2.Price.CompareTo(p1.Price));

        Product highestPriceProduct = products[0];
        Console.WriteLine($"Product with the highest price: {highestPriceProduct.Name} - {highestPriceProduct.Price}");
    }
}