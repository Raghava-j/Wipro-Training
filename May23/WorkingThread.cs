using System;
using System.Threading;
class Program
{
    static bool pause = false;
    static bool stop = false;
    static void DoWork()
    {
        while (!stop)
        {
            if (pause)
            {
                Console.WriteLine("Thread paused...");
                Thread.Sleep(500);
                continue;
            }
            Console.WriteLine("Thread is working...");
            Thread.Sleep(1000); // Simulated work
        }
        Console.WriteLine("Thread has stopped ");
    }
    static void Main()
    {
        Thread Worker = new Thread(DoWork);
        Console.WriteLine("Initial Thread State: " + Worker.ThreadState);
        Worker.Start();

        Thread.Sleep(3000);
        pause = true;
        Console.WriteLine("Paused Thread State: " + Worker.ThreadState);


        Thread.Sleep(3000);
        pause = false;
        Console.WriteLine("Resuming work...");

        Thread.Sleep(3000);
        pause = true;
        Console.WriteLine("Stopping thread...");

        Worker.Join(); // Wait for thread to finish
        Console.WriteLine("Final Thread State: " + Worker.ThreadState);
    }
}