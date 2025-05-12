using System;
abstract class Notification
{
    public void ShowType()
    {
        Console.WriteLine("Sending Notification");
    }
    public abstract void Send();
}
class EmailNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending Email Notification");
    }
}
class SMSNotification : Notification
{
    public override void Send()
    {
        Console.WriteLine("Sending SMS Notification");
    }
}
class Program
{
    static void Main()
    {
        Notification email = new EmailNotification();
        Notification sms = new SMSNotification();

        email.ShowType();
        email.Send();

        sms.ShowType();
        sms.Send();
    }
}