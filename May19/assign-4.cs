using System;
abstract class PaymentMethod
{
    protected string MethodName;
    public abstract void ProcessPayment(decimal amount);
    public void ShowPaymentMethod()
    {
        Console.WriteLine($"Payment Method: {MethodName}");
    }
}
class CreditCardPayment : PaymentMethod
{
    public CreditCardPayment()
    {
        MethodName = "Credit Card";
    }
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount}");
    }
}
class UPIPayment : PaymentMethod
{
    public UPIPayment()
    {
        MethodName = "UPI";
    }
    public override void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing UPI payment of {amount}");
    }
}
class Program
{
    static void Main()
    {
        PaymentMethod cc = new CreditCardPayment();
        PaymentMethod upi = new UPIPayment();

        cc.ShowPaymentMethod();
        cc.ProcessPayment(3000);

        Console.WriteLine();

        upi.ShowPaymentMethod();
        upi.ProcessPayment(1500);

        Console.WriteLine("\n ---Demonstrating Polymorphism-----");
        List<PaymentMethod> payments = new List<PaymentMethod>
        {
            new CreditCardPayment(),
            new UPIPayment()
        };
        foreach (PaymentMethod payment in payments)
        {
            Console.WriteLine();
            payment.ShowPaymentMethod();
            payment.ProcessPayment(888);

        }
    }
}