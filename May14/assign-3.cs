using System;
abstract class TicketBooking
{
    public abstract void BookTicket(int seats);

    public void ShowBookingInfo()
    {
        Console.WriteLine("Booking Tickets");
    }
}

class BusBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} bus tickets");
    }
}

class FlightBooking : TicketBooking
{
    public override void BookTicket(int seats)
    {
        Console.WriteLine($"Booking {seats} flight tickets");
    }
}
class Program
{
    static void Main()
    {
        TicketBooking bus = new BusBooking();
        TicketBooking flight = new FlightBooking();
        Console.WriteLine("Bus Booking");
        bus.ShowBookingInfo();
        bus.BookTicket(5);

        Console.WriteLine("\nFlight Booking:");
        flight.ShowBookingInfo();
        flight.BookTicket(3);
    }
}