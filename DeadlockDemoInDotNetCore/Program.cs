// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Exploring Deadlock With an Incorrectly Designed Application ***");

Thread.CurrentThread.Name = "Main Thread";
Console.WriteLine($"{Thread.CurrentThread.Name} starting...");

SharedResource sharedResource = new();
Thread thread1 = new(sharedResource.SharedMethod1)
{
    Name = "Child Thread-1",
};

Thread thread2 = new(sharedResource.SharedMethod2)
{
    Name = "Child Thread-2",
};

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine($"...{Thread.CurrentThread.Name} exiting.");
