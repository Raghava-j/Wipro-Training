using System;
using System.Threading;
class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(500);
        }
    }
    static void Main()
    {
        Thread myThread = new Thread(PrintNumbers);    // Create a Thread
         myThread.Start();                            // Start the thread
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Main: {i}");
            Thread.Sleep(500);
        }
    }
}