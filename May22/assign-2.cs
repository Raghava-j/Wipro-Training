using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();

        phoneBook["Ravi"] = "9848022338";
        phoneBook["Jathin"] = "7989249888";
        phoneBook["Ganesh"] = "9347326151";

        Console.WriteLine("Phone Book Contacts: ");
        foreach (var contact in phoneBook)
        {
            Console.WriteLine($"Name: {contact.Key}, Phone: {contact.Value}");
        }
        Console.WriteLine("\nWrite a name to search: ");
        string searchName = Console.ReadLine();
        if (phoneBook.ContainsKey(searchName))
        {
            Console.WriteLine($"Phone number of {searchName}: {phoneBook[searchName]}");
        }
        else
        {
            Console.WriteLine("Contact not found");
        }
    }
}