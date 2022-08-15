namespace EventsEx6;

internal class ReceiverAfter
{
    public void GetNotificationFromSender(object sender, EventArgs eventArgs)
        => Console.WriteLine("ReceiverAfter receives: Sender has changed MyInt.");
}
