using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main()
    {
        List<string> imageFiles = new List<string>();
        for (int i = 1; i <= 20; i++)
        {
            imageFiles.Add($"Image_{i}.jpg");
        }

        int total = imageFiles.Count;
        int completed = 0;
        object lockObj = new object();

        await Parallel.ForEachAsync(imageFiles, async (file, token) =>
        {
            await Task.Delay(200); 

            lock (lockObj)
            {
                completed++;
                double progress = (completed / (double)total) * 100;
                Console.WriteLine($"Processed {file} - {progress:F1}% complete");
            }
        });
    }
}