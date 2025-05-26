using System;
using System.Collections.Generic;
public interface IPaymentProcessor
{
    void ProcessPayment(decimal amount);
}
public abstract class PaymentGateway
{
    public string GatewayName { get; set; }

    public virtual bool Validate()
    {
        Console.WriteLine($"{GatewayName}: Validation successful.");
        return true;
    }
}
public class Razorpay : PaymentGateway, IPaymentProcessor
{
    public Razorpay()
    {
        GatewayName = "Razorpay";
    }
    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing {amount:C} through {GatewayName}.");
        }
    }
}
public class PayPal : PaymentGateway, IPaymentProcessor
{
    public PayPal()
    {
        GatewayName = "PayPal";
    }
    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing {amount:C} through {GatewayName}");
        }
    }
}
public class Stripe : PaymentGateway, IPaymentProcessor
{
    public Stripe()
    {
        GatewayName = "Stripe";
    }
    public void ProcessPayment(decimal amount)
    {
        if (Validate())
        {
            Console.WriteLine($"Processing {amount:C} through {GatewayName}.");
        }
    }
}
public class Program
{
    public static void Main()
    {
        List<IPaymentProcessor> payments = new List<IPaymentProcessor>
        {
            new Razorpay(),
            new PayPal(),
            new Stripe()
        };

        decimal[] amounts = { 100.0m, 200.5m, 150.75m };

        for (int i = 0; i < payments.Count; i++)
        {
            payments[i].ProcessPayment(amounts[i]);
        }
    }
}