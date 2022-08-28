// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Exploring Task-Based Asynchronous Pattern Using Async and Await ***");

Console.WriteLine($"Main(), ThreadId: {Environment.CurrentManagedThreadId}");

Task task1 = ExecuteTask1();

Method2();

await task1;

static async Task ExecuteTask1()
{
    await Task.Run(Method1);
}

static void Method1()
{
    Console.WriteLine($"Method1(), ThreadId: {Environment.CurrentManagedThreadId} starting...");
    Thread.Sleep(3000);
    Console.WriteLine("...Method1() ending.");
}

static void Method2()
{
    Console.WriteLine($"Method2(), ThreadId: {Environment.CurrentManagedThreadId} starting...");
    Thread.Sleep(100);
    Console.WriteLine("...Method2() ending.");
}
