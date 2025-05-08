using System;

using System.Collections.Generic;

class Program 
{
    static void Main()
    {
        Dictionary<string, string> phoneDirectory = new Dictionary<string, string>();

        phoneDirectory.Add("John", "984802338");
        phoneDirectory.Add("Ajay", "9346529149");
        phoneDirectory.Add("Jathin", "7989249888");
        phoneDirectory.Add("Ganesh", "9347326151");
        phoneDirectory.Add("Raghava", "8522921231");

        phoneDirectory["Ajay"] = "9494382248";

        if (phoneDirectory.ContainsKey("Ganesh"))
        {
            Console.WriteLine("Ganesh is in the phone directory.");
        }
        else
        {
            Console.WriteLine("Ganesh is not found");
        }

        Console.WriteLine("\nPhone Directory: ");
        foreach (var contact in phoneDirectory)
        {
            Console.WriteLine(contact.Key + ": " + contact.Value);
        }
    }
}