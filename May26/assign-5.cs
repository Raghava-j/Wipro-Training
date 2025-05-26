using System;
using System.Threading;
using System.Threading.Tasks;

public class Program
{
    static Random rand = new Random();
    public static async  Task<string> Server1Async(CancellationToken token)
    {
        int delay = rand.Next(1000, 3000);
        await Task.Delay(delay, token);
        return $"Server1 responded in {delay} ms";
    }
    public static async Task<string> Server2Async(CancellationToken token)
    {
        int delay = rand.Next(1000, 3000);
        await Task.Delay(delay, token);
        return $"Server2 responded in {delay} ms";
    }
    public static async Task<string> Server3Async(CancellationToken token)
    {
        int delay = rand.Next(1000, 3000);
        await Task.Delay(delay, token);
        return $"Server3 responded in {delay} ms";
    }
    public static async Task Main()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();

        var task1 = Server1Async(cts.Token);
        var task2 = Server2Async(cts.Token);
        var task3 = Server3Async(cts.Token);

        var allTasks = new[] { task1, task2, task3 };

        Task<string> winner = await Task.WhenAny(allTasks);
        Console.WriteLine($"Fastest: {winner.Result}");

        cts.Cancel();

        try
        {
            await Task.WhenAll(allTasks);
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("Some Server tasks were canceled:");
        }
    }
}