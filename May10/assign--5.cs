using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class ChatBot
    {
        public string Respond(string greeting)
        {
            return $"Hello! You said: {greeting}";
        }
        public string Respond(string question, bool isFormal)
        {
            if (isFormal)
            {
                return $"Thank you for your question. Regarding \"{question}\", let me provide a detailed response.";
            }
            else
            {
                return $"Hmm, \"{question}\"? That's a good one! Let me think...";
            }
        }
        public string Respond(int number)
        {
            return $"You mentioned the number{number}. That's quite intresting!";
        }
    }
}
using System;
namespace ConsoleApp1;
class Program
{
    static void Main()
    {
        ChatBot bot = new ChatBot();

        string response1 = bot.Respond("Hi, ChatBot!");
        string response2 = bot.Respond("What's your name?", false);
        string response3 = bot.Respond("Can you help with my homework?", true);
        string response4 = bot.Respond(2025);

        Console.WriteLine(response1);
        Console.WriteLine(response2);
        Console.WriteLine(response3);
        Console.WriteLine(response4);
    }
}