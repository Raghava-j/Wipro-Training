using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        var tasks = new List<Task>
        {
            Task.Run(() => Task.Delay(500)),
            Task.Run(() => throw new InvalidOperationException("Invalid operation in Task 2")),
            Task.Run(() => Task.Delay(300)),
            Task.Run(() => throw new ArgumentException("Bad argument in Task 4")),
            Task.Run(() => Task.Delay(200))
        };

        try
        {
            await Task.WhenAll(tasks);
        }
        catch (AggregateException ex)
        {
            Console.WriteLine(" Exceptions caught:");
            foreach (var inner in ex.InnerExceptions)
            {
                Console.WriteLine($"- {inner.GetType().Name}: {inner.Message}");
            }
        }

        Console.WriteLine(" All tasks completed (some may have failed).");
    }
}