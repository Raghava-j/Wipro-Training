using System;
using System.Linq;
class Program
{
    static void Main()
    {
        string sentence = "C# is great and c# is fun";

        var words = sentence
            .Split(new[] { ' ', '.', ',', '!', '?', ';', ':' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(w => w.ToLower());

        var wordGroups = words
            .GroupBy(w => w)
            .Select(g => new { Word = g.Key, Count = g.Count() });

        Console.WriteLine("Word Frequency:");
        foreach (var item in wordGroups)
        {
            Console.WriteLine($"{item.Word}: {item.Count}");
        }
    }
}