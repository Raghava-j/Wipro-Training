using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;

public class Item
{
    public string Name { get; set; }
    public string Type { get; set; }
    public int Stock { get; set; }
    public decimal Price { get; set; }

}
public class Program
{
    public static void Main()
    {
        List<Item> inventory = new List<Item>
        {
            new Item {Name = "Hammer", Type = "Tool", Stock = 10, Price= 300.00m},
            new Item {Name = "Screwdriver", Type = "Tool", Stock = 3, Price= 300.00m},
            new Item {Name = "Wrench", Type = "Tool", Stock = 6, Price= 300.00m},
            new Item {Name = "Laptop", Type = "Electronics", Stock = 2, Price= 300.00m},
            new Item {Name = "Mouse", Type = "Electronics", Stock = 15, Price= 300.00m},
            new Item {Name = "Keyboard", Type = "Electronics", Stock = 7, Price= 300.00m},
            new Item {Name = "DeskChair", Type = "Furniture", Stock = 4, Price= 300.00m},
            new Item {Name = "OfficeDesk", Type = "Furniture", Stock = 2, Price= 300.00m},
            new Item {Name = "Monitor", Type = "Electronics", Stock = 5, Price= 300.00m},
            new Item {Name = "Table", Type = "Furniture", Stock = 6, Price= 300.00m},
            new Item {Name = "Pen", Type = "Stationary", Stock = 50, Price= 300.00m},
            new Item {Name = "NoteBook", Type = "Stationary", Stock = 20, Price= 300.00m},
            new Item {Name = "Stapler", Type = "Stationary", Stock = 4, Price= 300.00m},
            new Item {Name = "Couch", Type = "Furniture", Stock = 1, Price= 300.00m},
            new Item {Name = "Drill", Type = "Tool", Stock = 2, Price= 300.00m}
        };
        var lowStockItems = inventory.Where(item => item.Stock < 5).ToList();
        Console.WriteLine("Low Stock Items (stock < 5):");
        foreach (var item in lowStockItems)
        {
            Console.WriteLine($"- {item.Name} ({item.Type}): Stock = {item.Stock}, Price = {item.Price:C} ");
        }
        var groupedByType = inventory.GroupBy(item => item.Type);
        Console.WriteLine("\n Items Grouped by Type:");
        foreach (var group in groupedByType)
        {
            Console.WriteLine($"\nType: {group.Key}");
            foreach (var item in group)
            {
                Console.WriteLine($"- {item.Name} (Stock: {item.Stock}, Price: {item.Price:C})");
            }
        }
        Console.WriteLine("\n Highest Priced item per type: ");
        foreach (var group in groupedByType)
        {
            var highest = group.OrderByDescending(item => item.Price).First();
            Console.WriteLine($"- {group.Key}: {highest.Name} at {highest.Price:C}");
        }
       
    }
}