using System;
class Program
{
    static void Main()
    {
        String sentence ="Learning C# is really interesting";
        string[] words = sentence.Split(' ');
        string longest ="";

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > longest.Length)
            {
                longest = words[i];
            }
        }
        Console.WriteLine("Longest word: " + longest);
    }
}
