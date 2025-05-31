using System;
using System.Collections.Generic;

class Question
{
    public string Text { get; set; }
    public List<string> Options { get; set; }
    public int CorrectOptionIndex { get; set; }

    public bool Ask()
    {
        Console.WriteLine("\n" + Text);
        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {Options[i]}");
        }

        Console.Write("Your answer (1-4): ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            return choice - 1 == CorrectOptionIndex;
        }
        return false;
    }
}
class Program
{
    static void Main()
    {
        List<Question> questions = new List<Question>
        {
            new Question
            {
                Text = "What is the capital of Andhra Pradesh?",
                Options = new List<string> {"Amaravathi", "Vishakapatnam", "Kurnool", "Kadapa" },
                CorrectOptionIndex = 1
            },
            new Question
            {
                Text = "Which planet is known as the Red Planet?",
                Options = new List<string> {"Earth", "Mars", "Venus", "Jupiter" },
                CorrectOptionIndex = 1
            },
            new Question
            {
                Text = "What is 5 * 10 ?",
                Options = new List<string> {"10", "50", "60","90"},
                CorrectOptionIndex = 2
            }
        };
        Random rand = new Random();
        int score = 0;
        int total = 3;

        Console.WriteLine("=== Quiz Start ===");
        for (int i = 0; i < total; i++)
        {
            int index = rand.Next(questions.Count);
            Question q = questions[index];
            questions.RemoveAt(index);

            bool correct = q.Ask();
            if (correct)
            {
                Console.WriteLine("Correct!");
                score++;
            }
            else
            {
                Console.WriteLine("Wrong!");
            }
        }
        Console.WriteLine("\nYour score: {score}/{total}");
    }
}