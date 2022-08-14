namespace EventsEx3;

internal class Receiver
{
    public void GetNotificationFromSender(object sender, JobNumberEventArgs jobNumberEventArgs)
        => Console.WriteLine($"Received a notification: Send has changed MyInt " +
            $"to {jobNumberEventArgs.JobNumber}");
}
