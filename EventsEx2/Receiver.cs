namespace EventsEx2;

internal class Receiver
{
    public void GetNotificationFromSender(object sender, EventArgs eventArgs)
        => Console.WriteLine("Receiver received a notification: Sender has changed the MyInt value.");
}
