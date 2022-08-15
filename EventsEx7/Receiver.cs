namespace EventsEx7;

internal class Receiver
{
    public void GetNotificationFromSender(object sender, EventArgs eventArgs)
        => Console.WriteLine("Receiver receives a notification: Sender has changed MyInt.");
}
