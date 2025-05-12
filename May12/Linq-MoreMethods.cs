using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace Linq_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Anil", "Sharma", "Abdullah", "Imran", "Siva", "Naresh", "Suresh", "Suman" };

            //Using LINQ Queries

            UsingAnonymousMethods(names);
        }
        // private static void UsingLinq(string[] names)
        // {
        // IEnumerable<string> query = from s in names
        //                        where s.Length == 5
        //                          orderby s
        //                            select s.ToUpper();
        // select * from

        // foreach (string item in query)
        //       Console.WriteLine(item);
        //     Console.Read();

        //   }

        //   private static void UsingLinq(string[] names)
        // {
        //   IEnumerable<string> query = names
        //                              .Where(s => s.Length == 5)
        //                            .OrderBy(s => s)
        //                          .Select(s => s.ToUpper());
        // Select * from
        // foreach (string item in query)
        //   Console.WriteLine(item);
        //  Console.Read();
        //  }
        //private static void UsingLINQFunction(string[] names)
        //{
            //Func<string, bool> filter = s => s.Length == 5;
            //Func<string, string> extract = s => s;
            //Func<string, string> project = s => s.ToUpper();
            //
            // IEnumerable<string> query = names.Where(filter)
                //                            .OrderBy(extract)
              //                              .Select(project);
            //foreach (string item in query)
          //      Console.WriteLine(item);
        //    Console.Read();
     //    }



        private static void UsingAnonymousMethods(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                // more lines of code 
                return s.Length == 5;

            };
            Func<string, string> extract = delegate (string s)
            {
                return s;
            };
            Func<string, string> project = delegate (string s)
            {
                return s.ToUpper();
            };
            IEnumerable<string> query = names.Where(filter)
                                            .OrderBy(extract)
                                            .Select(project);
            foreach (string item in query)
                Console.WriteLine(item);
        }
    }
}