using System;
using System.Diagnostics;
using System.Threading.Tasks;

class WeatherFetcher
{
    public async Task<string> GetWeatherAsync(string city)
    {
        Console.WriteLine($"Fetching weather for {city}.....");

        Random rnd = new Random();
        int delay = rnd.Next(1000, 5000);
        await Task.Delay(delay);

        return $"{city}: {20 + rnd.Next(10)} (fetched in {delay} ms)";
        
    }
}
class Program
{
    static async Task Main()
    {
        WeatherFetcher fetcher = new WeatherFetcher();
        string[] cities = { "Delhi", "Mumbai", "Chennai", "Hyderabad" };

        var stopwatch = Stopwatch.StartNew();

        var tasks = new Task<string>[]
        {
            fetcher.GetWeatherAsync(cities[0]),
            fetcher.GetWeatherAsync(cities[1]),
            fetcher.GetWeatherAsync(cities[2]),
            fetcher.GetWeatherAsync(cities[3])
        };
        var results = await Task.WhenAll(tasks);
        stopwatch.Stop();

        Console.WriteLine("\nWeather Results");
        foreach (var result in results)
        {
            Console.WriteLine(result);

        }
        Console.WriteLine($"\nTotal time taken: {stopwatch.ElapsedMilliseconds}ms");
    }
}