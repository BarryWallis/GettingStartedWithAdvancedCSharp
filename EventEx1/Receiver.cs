namespace EventsEx1;

internal class Receiver
{
    public void GetNotificationFromSender(object sender, EventArgs eventArgs)
        => Console.WriteLine("Receiver recieved a notification: Sender has changed the myInt value.");
}
