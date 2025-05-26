using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
public class Worker
{
    private Queue<string> taskQueue = new Queue<string>();
    private object queueLock = new object();
    private bool running = true;

    public void Start()
    {
        Thread thread = new Thread(ProcessTasks);
        thread.Start();
    }
    public void EnqueueTask(string task)
    {
        lock (queueLock)
        {
            taskQueue.Enqueue(task);
            Monitor.Pulse(queueLock);
        }
    }
    public void Stop()
    {
        running = false;
        lock (queueLock)
        {
            Monitor.Pulse(queueLock);
        }
    }
    private void ProcessTasks()
    {
        while (running)
        {
            string task = null;
            lock (queueLock)
            {
                while (taskQueue.Count == 0 && running)
                {
                    Monitor.Wait(queueLock);
                }
                if (taskQueue.Count > 0)
                {
                    task = taskQueue.Dequeue();
                }
            }
            if (task != null)
            {
                Console.WriteLine($"Processing: {task}");
                Thread.Sleep(1000);
            }
        }
        Console.WriteLine("Worker thread exixting...");
    }
 
}
public class Program
{
    public static void Main()
    {
        Worker worker = new Worker();
        worker.Start();
        for (int i = 1; i <= 5; i++)
        {
            string task = $"Task {i}";
            Console.WriteLine($"Enqueuing: {task}");
            worker.EnqueueTask(task);
            Thread.Sleep(500);
        }
        Thread.Sleep(7000);
        worker.Stop();
    }
}