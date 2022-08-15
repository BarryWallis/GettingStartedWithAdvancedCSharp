namespace EventsEx6;

internal class ReceiverBefore
{
    public void GetNotificationFromSender(object sender, EventArgs eventArgs)
        => Console.WriteLine("ReceiverBefore receives: Sender is about to change MyInt.");
}
