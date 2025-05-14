using System;
abstract class FoodOrder
{
    public abstract void PlaceOrder(string item);
    public void OrderInfo()
    {
        Console.WriteLine("Placing food order");
    }
}
class FastFoodOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"Order placed for {item} at Fast Food Outlet");
    }
}
class FineDiningOrder : FoodOrder
{
    public override void PlaceOrder(string item)
    {
        Console.WriteLine($"order placed for {item} at fine dining restaurant");
    }
}
class Program
{
    static void Main()
    {
        FoodOrder ff = new FastFoodOrder();
        FoodOrder fd = new FineDiningOrder();

        Console.WriteLine("Fast Food Order: ");
        ff.OrderInfo();
        ff.PlaceOrder("Burger");

        Console.WriteLine("\nFine Dining Order");
        fd.OrderInfo();
        fd.PlaceOrder("Strak");
    }
}