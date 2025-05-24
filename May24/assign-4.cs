using System;
using System.Diagnostics;
using System.Threading.Tasks;
class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Starting parallel downloads ....\n");
        var stopwatch = Stopwatch.StartNew();

        Task t1 = DownloadFileAsync("File1.txt", 2000);
        Task t2 = DownloadFileAsync("File2.txt", 2000);
        Task t3 = DownloadFileAsync("File3.txt", 2000);

        await Task.WhenAll(t1, t2, t3);

        stopwatch.Stop();
        Console.WriteLine($"\nAll downloads completed in {stopwatch.ElapsedMilliseconds} ms.");
    }
    static async Task DownloadFileAsync(string fileName, int delay)
    {
        Console.WriteLine($"{fileName} download started");
        await Task.Delay(delay);
        Console.WriteLine($"{fileName} download completed after {delay} ms.");
    }
}