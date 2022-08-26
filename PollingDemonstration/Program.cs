internal class Program
{
    public delegate void Method1Delegate(int sleepTimeMillisecond);

    private static void Main()
    {
        Console.WriteLine("*** Polling Demonstration ***");

        Console.WriteLine($"Inside Main(), ThreadId {Environment.CurrentManagedThreadId}.");

        Method1Delegate method1Delegate = Method1;
        IAsyncResult asyncResult = method1Delegate.BeginInvoke(3000, null, null);

        Method2();
        while (!asyncResult.IsCompleted)
        {
            Console.Write("*");
            Thread.Sleep(5);
        }

        method1Delegate.EndInvoke(asyncResult);

        void Method1(int sleepTimeMillisecond)
        {
            Console.WriteLine("Starting Method1()...");
            Console.WriteLine($"Inside Method1(), ThreadId {Environment.CurrentManagedThreadId}.");
            Thread.Sleep(sleepTimeMillisecond);
            Console.WriteLine();
            Console.WriteLine("...Ending Method1()");
        }

        void Method2()
        {
            Console.WriteLine("Starting Method2()...");
            Console.WriteLine($"Inside Method2(), ThreadId {Environment.CurrentManagedThreadId}.");
            Thread.Sleep(100);
            Console.WriteLine("...Ending Method1()");
        }
    }
}
