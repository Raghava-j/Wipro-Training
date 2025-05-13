using System;
namespace PaymentProcessing
{
    public abstract class PaymentGateway
    {
        public abstract void ProcessPayment(double amount);

        public void ShowGatewayName()
        {
            Console.WriteLine("Processing payment through Gateway");
        }
    }
    public class StripeGateway : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment through stripe : {amount}");
        }
    }
    public class PayPalGateway : PaymentGateway
    {
        public override void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing payment through PayPal: {amount}");
        }
    }
    class Program
    {
        static void Main()
        {
            PaymentGateway stripe = new StripeGateway();
            PaymentGateway paypal = new PayPalGateway();

            stripe.ShowGatewayName();
            stripe.ProcessPayment(15000.00);

            paypal.ShowGatewayName();
            paypal.ProcessPayment(32000.75);

            Console.ReadLine();
        }
    }
}