using System;
class Program{
    static void Main()
    {
        string sentence = "This is a test and this test is fun";
        string[] words = sentence.ToLower().Split(' ');
        bool[] visited = new bool[words.Length];
        Console.Write("Duplicate words: ");

        for (int i = 0; i < words.Length; i++)
        {
            if (visited[i])
                continue;
            int count = 1;
            for (int j = i + 1; j < words.Length; j++)
            {
                if (words[i] == words[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            if (count > 1)
            {
                Console.Write(words[i] + ", ");
            }
        }
        Console.WriteLine("\b\b ");
    }
}