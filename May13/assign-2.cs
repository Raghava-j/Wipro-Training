using System;
namespace RestaurantOrderManagement
{
    public interface IOrder
    {
        void PlaceOrder(string item);
        void CancelOrder(string item);
    }
    public class DineInOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing dine-in order for {item}");
        }
        public void CancelOrder(string item)
        {
            Console.WriteLine($"Canceling dine-in order for {item}");
        }
    }
    public class TakeawayOrder : IOrder
    {
        public void PlaceOrder(string item)
        {
            Console.WriteLine($"Placing dine-in order for {item}");
        }
        public void CancelOrder(string item)
        {
            Console.WriteLine($"Canceling dine-in order for {item}");
        }
    }

    class Program
    {
        static void Main()
        {
            IOrder dineIn = new DineInOrder();
            IOrder takeaway = new TakeawayOrder();

            dineIn.PlaceOrder("Pasta");
            dineIn.CancelOrder("Pasta");

            takeaway.PlaceOrder("Burger");
            takeaway.CancelOrder("Burger");
        }
    }
}