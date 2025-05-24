using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting risky tasks...\n");

        Task t1 = RiskyTaskAsync("Task A");
        Task t2 = RiskyTaskAsync("Task B");
        Task t3 = RiskyTaskAsync("Task c");

        try
        {
            await Task.WhenAll(t1, t2, t3);
        }
        catch (Exception ex)
        {
            Console.WriteLine("\n [ERROR] One or more tasks failed:");
            foreach (var task in new[] {t1, t2, t3})
            {
                if (task.IsFaulted)
                {
                    Console.WriteLine($"- {task.Exception?.InnerException?.Message}");
                }
            }
        }
        Console.WriteLine("\nFinished handling tasks");
    }
    static async Task RiskyTaskAsync(string name)
    {
        Console.WriteLine($"{name} started...");

        await Task.Delay(1000);

        if (name == "Task B")
            throw new Exception($"{name} failed intentionally!");
        Console.WriteLine($"{name} completed successfully.");
    }
}