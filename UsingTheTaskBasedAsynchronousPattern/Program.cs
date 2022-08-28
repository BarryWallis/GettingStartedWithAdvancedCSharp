// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Using The Task-Based Asynchronous Pattern ***");

Console.WriteLine($"Main() ManagedThreadId: " +
    $" {Environment.CurrentManagedThreadId}");
Task taskForMethod1 = new(Method1);
taskForMethod1.Start();

Method2();

taskForMethod1.Wait();

void Method1()
{
    Console.WriteLine("Method1() starting...");
    Console.WriteLine($"Method1, ManagedThreadId: {Environment.CurrentManagedThreadId}");
    Thread.Sleep(3000);
    Console.WriteLine("...Method1() ending.");
}

void Method2()
{
    Console.WriteLine("Method2() starting...");
    Console.WriteLine($"Method2, ManagedThreadId: {Environment.CurrentManagedThreadId}");
    Thread.Sleep(100);
    Console.WriteLine("...Method2() ending.");
}
