using System;
using System.Collections.Generic;
using System.Linq;
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
}
class  Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product {Name = "Laptop", Price = 75000},
            new Product {Name = "Mouse", Price = 150},
            new Product {Name = "Phone", Price = 25000},
            new Product {Name = "keyboard", Price = 1000},
            new Product { Name = "Monitor", Price = 800}
        };

        var expensiveProducts = products
            .Where(p => p.Price > 500)
            .ToList();

        Console.WriteLine("Products with Price > 500: ");
        foreach (var product in expensiveProducts)
        {
            Console.WriteLine($"Name: {product.Name}, Price: {product.Price}");
        }
    }
}