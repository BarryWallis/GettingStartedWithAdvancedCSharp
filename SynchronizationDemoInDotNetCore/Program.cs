// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Exploring Thread Synchronization ***");
Console.WriteLine("*** With a Non-Syncronized Version ***");

Thread.CurrentThread.Name = "Main Thread";
Console.WriteLine("Main Thread starting...");

SharedResource sharedResource = new();
Thread thread1 = new(sharedResource.SharedMethod)
{
    Name = "Child Thread-1"
};

Thread thread2 = new(sharedResource.SharedMethod)
{
    Name = "Child THread-2"
};

thread1.Start();
thread2.Start();

thread1.Join();
thread2.Join();

Console.WriteLine($"The {Thread.CurrentThread.Name} exiting.");
