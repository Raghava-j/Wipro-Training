using System;
using System.IO;
using System.Threading;
class FileProcessor
{
    static int totalLines = 0;
    static readonly object lockObj= new object();

    static void ProcessFile(string filePath)
    {
        int lineCount = 0;
        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                while (reader.ReadLine() != null)
                {
                    lineCount++;
                }
            }
            Console.WriteLine($"{Path.GetFileName(filePath)}: {lineCount} lines");

            lock (lockObj)
            {
                totalLines += lineCount;
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error reading{filePath}: {e.Message}");
        }
    }
    static void Main()
    {
        string file1 = "file1.txt";
        string file2 = "file2.txt";
        string file3 = "file3.txt";

        Thread t1 = new Thread(() => ProcessFile(file1));
        Thread t2 = new Thread(() => ProcessFile(file2));
        Thread t3 = new Thread(() => ProcessFile(file3));

        t1.Start();
        t2.Start();
        t3.Start();

        t1.Join();
        t2.Join();
        t3.Join();

        Console.WriteLine($"\nTotal lines across all files: {totalLines}");
    }
}