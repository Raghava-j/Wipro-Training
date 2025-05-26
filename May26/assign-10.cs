
using System;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        string paragraph = "This is a sample paragraph. This paragraph is meant to demonstrate word frequency. Frequency analysis is useful in many applications.";

        string[] words = paragraph
            .ToLower()
            .Split(new char[] { ' ', '.', ',', '!', '?', ';', ':', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (var word in words)
        {
            if (frequency.ContainsKey(word))
                frequency[word]++;
            else
                frequency[word] = 1;
        }

        var topWords = frequency
            .OrderByDescending(kvp => kvp.Value)
            .Take(5);

        Console.WriteLine("Top 5 most frequent words:");
        foreach (var kvp in topWords)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value}");
        }
    }
}
