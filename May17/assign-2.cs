using System;
public interface ISupportTicket
{
    void CreateTicket(string issue);
    void ResolveTicket(int ticketId);
}
public class EmailSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via Email: {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Email");
    }
}

public class PhoneSupport : ISupportTicket
{
    public void CreateTicket(string issue)
    {
        Console.WriteLine($"Creating ticket via phone: {issue}");
    }
    public void ResolveTicket(int ticketId)
    {
        Console.WriteLine($"Resolving ticket {ticketId} via Phone");
    }
}
class Program
{
    static void Main()
    {
        ISupportTicket email = new EmailSupport();
        ISupportTicket phone = new PhoneSupport();

        email.CreateTicket("Unable to login");
        email.ResolveTicket(101);
        phone.CreateTicket("Payment Failed");
        phone.ResolveTicket(105);
    }
}