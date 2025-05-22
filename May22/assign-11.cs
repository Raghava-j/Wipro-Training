using System;
using System.Collections.Generic;
using System.Linq;
class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product {Id = 1,Name = "Laptop", Price = 75000},
            new Product {Id = 2,Name = "Mouse", Price = 150},
            new Product {Id = 3,Name = "Phone", Price = 25000},
            new Product {Id = 4,Name = "keyboard", Price = 1000},
            new Product {Id = 5,Name = "Monitor", Price = 800}
        };

        var sortedProducts = products
            .OrderByDescending(p => p.Price)
            .ToList();
        Console.WriteLine("Products sorted by price (descending): ");
        foreach (var product in sortedProducts)
        {
            Console.WriteLine($"Id: {product.Id},Name: {product.Name}, Price: {product.Price}");
        }
    }
}