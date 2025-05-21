using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Dictionary<char, int> frequencyMap = new Dictionary<char, int>();

        foreach (char ch in input)
        {
            if (frequencyMap.ContainsKey(ch))
                frequencyMap[ch]++;
            else
                frequencyMap[ch] = 1;
        }
        foreach (char ch in input)
        {
            if (frequencyMap[ch] == 1)
            {
                Console.WriteLine("First non-repeating character: " + ch);
                return;
            }
        }
        Console.WriteLine("No non-repeating character found.");
    }
}