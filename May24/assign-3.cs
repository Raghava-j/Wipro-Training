using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Console.WriteLine("Queueing 5 items to ThreadPool....\n");

        for(int i = 1; i <= 5; i++)
        {
            ThreadPool.QueueUserWorkItem(ProcessItem, i);
        }
        Thread.Sleep(3000);
        Console.WriteLine("\nAll tasks queued to thread pool.");
    }
    static void ProcessItem(object item)
    {
        int itemId = (int)item;
        Console.WriteLine($"Processing item {itemId} on thread {Thread.CurrentThread.ManagedThreadId}");
        Thread.Sleep(1000);
        Console.WriteLine($"Finished item {itemId} on thread {Thread.CurrentThread.ManagedThreadId}");
    }
}