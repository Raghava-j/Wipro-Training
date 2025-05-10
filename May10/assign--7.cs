using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Payment
    {
        public double Amount;
        public string Currency;
        public virtual void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"Amount: {Amount}");
            Console.WriteLine($"Currency: {Currency}");
        }

    }
    class CreditCardPayment : Payment
    {
        public int CardNumber;
        public override void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"Amount: { Amount}");
        }
    }
    class PayPalPayment : Payment
    {
   
        public string EmailAddress;
        public override void ProcessPayment(double Amount, string Currency)
        {
            Console.WriteLine($"Amount is: {Amount}");
            Console.WriteLine($"Currency: {Currency}");
        }
    }

}

using System;
namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            CreditCardPayment cc = new CreditCardPayment();
            Console.WriteLine("Creditcard Payment Details");
            cc.ProcessPayment(100000,"INR");

            PayPalPayment pp = new PayPalPayment();
            Console.WriteLine("\n PayPal Payment Details");
            pp.ProcessPayment(80000, "INR");
        }
    }
}