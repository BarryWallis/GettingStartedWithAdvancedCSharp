namespace EventsEx3;

internal class JobNumberEventArgs : EventArgs
{
    public int JobNumber { get; init; }

    public JobNumberEventArgs(int jobNumber) => JobNumber = jobNumber;
}
