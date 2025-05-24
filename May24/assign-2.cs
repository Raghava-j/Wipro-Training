using System;
using System.Threading;
class Program
{
    static void Main()
    {
        Thread t1 = new Thread(() =>
        {
            Console.WriteLine("Thread 1: Printing Numbers...");
            for (int i = 1; i <= 5;
            i++)
            {
                Console.WriteLine($"Thread 1: {i}");
                Thread.Sleep(500);

            }
            Console.WriteLine("Thread 1 finished");
        });

        Thread t2 = new Thread(() =>
        {
            Console.WriteLine("Thread2: Sum ={sum}");
            long sum = 0;
            for (int i = 1; i <= 1000000; i++)
                sum += i;
            Console.WriteLine($"Thread 2: Sum = {sum}");
            Console.WriteLine("Thread 2 finished");
        });
        Thread t3 = new Thread(() =>
        {
            Console.WriteLine("Thread 3: Simulateing delay...");
            Thread.Sleep(3000);
            Console.WriteLine("Thread 3 finished.");
        });

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();
    }
}