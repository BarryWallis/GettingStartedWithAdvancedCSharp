// See https://aka.ms/new-console-template for more information

internal class SharedResource
{
    private readonly object _lock1 = new();
    private readonly object _lock2 = new();

    public void SharedMethod1()
    {
        lock (_lock1)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} lock1 starting...");
            Thread.Sleep(1000);
            Console.WriteLine($"...{Thread.CurrentThread.Name} lock1 exiting.");
            lock (_lock2)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock2 starting...");
                Thread.Sleep(1000);
                Console.WriteLine($"...{Thread.CurrentThread.Name} lock2 exiting.");
            }
        }
    }

    public void SharedMethod2()
    {
        lock (_lock2)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} lock2 starting...");
            Thread.Sleep(1000);
            Console.WriteLine($"...{Thread.CurrentThread.Name} lock2 exiting.");
            lock (_lock1)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} lock1 starting...");
                Thread.Sleep(1000);
                Console.WriteLine($"...{Thread.CurrentThread.Name} lock1 exiting.");
            }
        }
    }
}