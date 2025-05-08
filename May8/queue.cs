using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> customers = new Queue<string>();

        // Adding customers to the queue
        customers.Enqueue("Rajesh");
        customers.Enqueue("Priya");
        customers.Enqueue("Neha");

        Console.WriteLine("Serving Customers:");
        while (customers.Count > 0)
        {
            Console.WriteLine("Serving: " + customers.Dequeue());
        }
    }
}