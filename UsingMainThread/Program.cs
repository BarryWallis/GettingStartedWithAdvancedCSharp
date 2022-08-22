// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Working on the Main Thread and a Child THread Only ***");

Thread.CurrentThread.Name = "Main Thread";

Thread thread1 = new(Method1)
{
    Name = "Child Thread-1",
    Priority = ThreadPriority.AboveNormal
};
Console.WriteLine("Starting thread1...");
thread1.Start();

Console.WriteLine($"Inside Main(), Thread Name is: {Thread.CurrentThread.Name}");
Console.WriteLine($"Inside Main(), ManagedThreadId is: {Thread.CurrentThread.ManagedThreadId}");
Console.WriteLine($"Inside Main(), Thread Priority is: {Thread.CurrentThread.Priority}");
Console.WriteLine("Control comes at end of Main()");

static void Method1()
{
    Console.WriteLine($"Inside Method1(), Thread Name is: {Thread.CurrentThread.Name}");
    Console.WriteLine($"Inside Method1(), ManagedThreadId is: {Thread.CurrentThread.ManagedThreadId}");
    Console.WriteLine($"Inside Method1(), Thread Priority is: {Thread.CurrentThread.Priority}");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"Inside Method1(), printing the value {i}");
    }
}