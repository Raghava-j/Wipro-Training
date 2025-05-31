using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class StringAnalyzer
{
    static void Main()
    {
        Console.WriteLine("Enter a paragraph: ");

        string input = Console.ReadLine();

        string cleaned = Regex.Replace(input.ToLower(), @"[^\w\s]", "");
        string[] words = cleaned.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        var wordFreq = words
            .GroupBy(w => w)
            .ToDictionary(g => g.Key, g => g.Count());
        Console.WriteLine("\nWord Frequency: ");
        foreach (var pair in wordFreq.OrderByDescending(p => p.Value))
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");

        }
        int vowels = 0, consonants = 0;
        foreach (char c in input.ToLower())
        {
            if (char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowels++;
                else
                    consonants++;
            }
        }
        Console.WriteLine($"\n Vowel Count: {vowels}");
        Console.WriteLine($"Consonant Count: {consonants}");

        var longest = words.OrderByDescending(w => w.Length).FirstOrDefault();
        var shortest = words.OrderBy(w => w.Length).FirstOrDefault();

        Console.WriteLine($"\n Longest Word: {longest}");
        Console.WriteLine($"Shortest Word: {shortest}");
    }
}