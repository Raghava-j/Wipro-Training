using System;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        using CancellationTokenSource cts = new CancellationTokenSource();
        Console.WriteLine("Starting work....");
        Task workTask = DoWorkAsync(cts.Token);

        await Task.Delay(2000);
        cts.Cancel();
        Console.WriteLine("[Main] Cancellation requested.");

        try
        {
            await workTask;
        }
        catch (OperationCanceledException)
        {
            Console.WriteLine("[Main] Task was cancelled.");
        }
        Console.WriteLine("Main finished.");

    }

    static async Task DoWorkAsync(CancellationToken token)
    {
        for (int i = 1; i <= 10; i++)
        {
            token.ThrowIfCancellationRequested();

            Console.WriteLine($"Working ... steps {i}");
            await Task.Delay(1000, token);
        }
        Console.WriteLine("Work completed successfully.");
    }
}