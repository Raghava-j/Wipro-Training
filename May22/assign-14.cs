//E-Commece Shopping Cart System
using System;
using System.Collections.Generic;
using System.Linq;

class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
}
class CartItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public double GetTotalPrice() => Product.Price * Quantity;

}
class ShoppingCart
{
    private List<CartItem> items = new List<CartItem>();
    public void AddItem(Product product, int quantity)
    {
        var existingItem = items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity += quantity;
        }
        else
        {
            items.Add(new CartItem { Product = product, Quantity = quantity });
        }
    }
    public void RemoteItem(int productId)
    {
        items.RemoveAll(i => i.Product.Id == productId);
    }
    public double GetCartTotal() => items.Sum(i => i.GetTotalPrice());
    public void PrintCart()
    {
        Console.WriteLine("Cart Items: ");
        foreach (var item in items)
        {
            Console.WriteLine($"{item.Product.Name} * {item.Quantity} = {item.GetTotalPrice()}");
        }
        Console.WriteLine($"Total Cart Value: {GetCartTotal()}");
    }
}
class Program
{
    static void Main()
    {
        var product1 = new Product { Id = 1, Name = "Laptop", Price = 7000 };
        var product2 = new Product { Id = 2, Name = "Mouse", Price = 1200 };
        var product3 = new Product { Id = 3, Name = "Headphones", Price = 3000 };

        var cart = new ShoppingCart();
        cart.AddItem(product1, 1);
        cart.AddItem(product2, 2);
        cart.AddItem(product3, 1);

        cart.PrintCart();
    }
}