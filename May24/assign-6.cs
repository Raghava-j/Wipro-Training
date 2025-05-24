using System;
using System.Threading.Tasks;
class Program
{
    static async Task Main()
    {
        Console.WriteLine("Starting tasks....\n");

        Task<string> task1 = DelayedTask("Task A", 3000);
        Task<string> task2 = DelayedTask("Task B", 2000);
        Task<string> task3 = DelayedTask("Task C", 1000);

        Task<string> firstFinished = await Task.WhenAny(task1, task2, task3);

        Console.WriteLine($"\nFirst complete: {firstFinished.Result}");
    }
    static async Task<string> DelayedTask(string name, int delay)
    {
        await Task.Delay(delay);
        return name;
    }
}