using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Practice
{
    internal class Action
    {
        public static void Main()
        {
            Action<int> printActionDel = ConsolePrint;
            Action<int> printToPrinter = PrintToPrinter;

            printActionDel(10);
            printToPrinter(45);
            Console.Read();
        }

        public static void ConsolePrint(int i)
        {
            Console.WriteLine(i);
        }
        public static void PrintToPrinter( int i)
        {
            Console.WriteLine("This is being printed to the printer");
        }
    }
}