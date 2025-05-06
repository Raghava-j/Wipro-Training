using System;

class Program
{
    static void Main()
    {
        string sentence = "Learning c# is fun";
        int wordCount = CountWords(sentence);
        Console.WriteLine($"{woedCount} words");
    }
    static int CountWords(string sentence)
    {
        if (string.IsNULLOrWhiteSpace(sentence))
           return 0;
        string[] words = sentence.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        return words.Length;
    }
}