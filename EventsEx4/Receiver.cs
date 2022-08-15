namespace EventsEx4;

internal class Receiver
{
    public void GetNotificationFromSender(object sender, JobNumberEventArgs jobNumberEventArgs)
        => Console.WriteLine($"Receiver received a notification: Sender has changed MyInt " +
            $"to {jobNumberEventArgs.JobNumber}");
}
