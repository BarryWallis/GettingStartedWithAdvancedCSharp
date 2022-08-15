namespace EventsEx5;

internal class Receiver
{
    public void GetNotificationFromSender(object sender, EventArgs eventArgs)
        => Console.WriteLine("Receiver received a notification: Sender has changed MyInt.");
}
