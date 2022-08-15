namespace EventsEx4
{
    internal class JobNumberEventArgs : EventArgs
    {
        public JobNumberEventArgs(int jobNumber) => JobNumber = jobNumber;

        public int JobNumber { get; init; }
    }
}
