using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Amal","David","Fazal","Kobra","Professor","James","Gibbs","Paine","Omkar","Bravo"
        };
        var vowelNames = names.Where(name => "AEIOU".Contains(Char.ToUpper(name[0])))
            .OrderBy(name => name)
            .ToList();
        Console.WriteLine("Names starting with a vowel:");
        foreach (var name in vowelNames)
        {
            Console.WriteLine(name);
        }
    }
}