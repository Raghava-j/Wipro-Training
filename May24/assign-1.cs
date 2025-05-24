using System;
using System.Threading;
class Program
{
    static bool stop = false;
    static ManualResetEvent pauseEvent = new ManualResetEvent(true);
    static Thread workerThread;

    static void Main()
    {
        workerThread = new Thread(PrintNumbers);
        workerThread.Start();

        Thread.Sleep(1000);
        Console.WriteLine("\n[Main] Pausing thread...");
        pauseEvent.Reset();
        PrintThreadState();

        Thread.Sleep(2000);
        Console.WriteLine("\n[Main] Resuming thread...");
        pauseEvent.Reset();
        PrintThreadState();

        Thread.Sleep(2000);
        Console.WriteLine("\n[Main] Stopping Thread... ");
        stop = true;
        pauseEvent.Set();
        workerThread.Join();
        PrintThreadState();

        Console.WriteLine("\n[Main] Thread has stopped");
    }
    static void PrintNumbers()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (stop)
                break;

            pauseEvent.WaitOne();
            Console.Write(i + " ");
            Thread.Sleep(100);
        }
    }
    static void PrintThreadState()
    {
        Console.WriteLine("[Status] ThreadState: " + workerThread.ThreadState);
    }
}