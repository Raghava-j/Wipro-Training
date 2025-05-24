using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Fetching temperatures...\n");
        {
            Task<int> temp1 = GetTemperatureAsync("New York");
            Task<int> temp2 = GetTemperatureAsync("London");
            Task<int> temp3 = GetTemperatureAsync("Tokyo");

            int[] results = await Task.WhenAll(temp1, temp2, temp3);

            Console.WriteLine($"\nTemperature in New York : {results[0]}C");
            Console.WriteLine($"Temperature in London: {results[1]}C");
            Console.WriteLine($"Temperature in Tokyo {results[2]}C");
        }
        static async Task<int> GetTemperatureAsync(string city)
        {
            await Task.Delay(1000);
            int temp = new Random().Next(-10, 35);
            Console.WriteLine($"[Log] {city} temperature fetched");
            return temp;
        }
    }
}