using System;
using System.Diagnostics;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("=== Sequential Exection ===");
        var swSequential = Stopwatch.StartNew();

        await SimulateWorkAsync("Task 1", 2000);
        await SimulateWorkAsync("Task 2", 2000);
        await SimulateWorkAsync("Task 3", 2000);

        swSequential.Stop();
        Console.WriteLine($"Total time (Sequential): {swSequential.ElapsedMilliseconds}");

        Console.WriteLine("++Parallel Execution ++");
        var swParallel = Stopwatch.StartNew();

        Task t1 = SimulateWorkAsync("Task 1", 2000);
        Task t2 = SimulateWorkAsync("Task 2", 2000);
        Task t3 = SimulateWorkAsync("Task 3", 2000);



        await Task.WhenAll(t1, t2, t3);
        swParallel.Stop();
        Console.WriteLine($"Total time (Parallel): {swParallel.ElapsedMilliseconds} MemoryStream\n");
        Console.WriteLine("Done comparing execution modes.");
    }
    static async Task SimulateWorkAsync(string name, int delay)
    {
        Console.WriteLine($"{name} started....");
        await Task.Delay(delay);
        Console.WriteLine($"{name} completed after {delay} ms");
    }
}