using System;
using System.Collections.Generic;
class Product
{
    public string Name { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }

}
interface IPrintable
{
    void Print();
}
abstract class Invoice : IPrintable
{
    public List<Product> Products = new List<Product>();

    public void AddProduct(string name, double price, int quantity)
    {
        Products.Add(new Product { Name = name, Price = price, Quantity = quantity });
    }
    public abstract double CalculateTotal();

    public virtual void Print()
    {
        Console.WriteLine("\n---Invoice ---");
        foreach (var product in Products)
        {
            Console.WriteLine($"{product.Name} - Qty: {product.Quantity} - Unit Price: {product.Price:C} - Subtotal: {(product.Price * product.Quantity):C}");
        }
        Console.WriteLine($"Total: {CalculateTotal():C}");
    }
}
class RetailInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
            subtotal += product.Price * product.Quantity;

        double tax = subtotal * 0.05;
        return subtotal + tax;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Retail Tax:5%");
    }
}
class WholesaleInvoice : Invoice
{
    public override double CalculateTotal()
    {
        double subtotal = 0;
        foreach (var product in Products)
            subtotal += product.Price * product.Quantity;
        double discount = subtotal * 0.10;
        return subtotal - discount;
    }
    public override void Print()
    {
        base.Print();
        Console.WriteLine("Wholesale Discount: 10%");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Choose invoice type (rental/wholesale): ");
        string type = Console.ReadLine()?.Trim().ToLower();
        Invoice invoice = type switch
        {
            "retail" => new RetailInvoice(),
            "wholesale" => new WholesaleInvoice(),
            _ => throw new Exception("Invalid invoice type")
        };

        invoice.AddProduct("Laptop", 1000, 1);
        invoice.AddProduct("Mouse", 25, 2);
        invoice.Print();
    }
}