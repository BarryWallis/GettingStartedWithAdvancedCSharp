// See https://aka.ms/new-console-template for more information

Console.WriteLine("*** Exploring Task-Based Asynchronous Pattern using Async and Await Version 3 ***");

Console.WriteLine($"Main(), ThreadId: {Environment.CurrentManagedThreadId}");

Task task1 = ExecuteTask1();

Method2();

await task1;

static async Task ExecuteTask1()
{
    Console.WriteLine("ExecuteTask1() before await...");
    int value = await Task.Run(Method1);
    Console.WriteLine("...ExecuteTask1() after await.");
    if (value != -1)
    {
        Method3();
    }
}

static int Method1()
{
    int flag = 0;
    try
    {
        Console.WriteLine($"Method1() starting, ThreadId: {Environment.CurrentManagedThreadId}...");
        Thread.Sleep(3000);
        Console.WriteLine("...Method1() ending.");
    }
    catch (Exception exception)
    {
        Console.WriteLine($"Caught Exception: {exception.Message}");
        flag = -1;
    }

    return flag;
}

static void Method2()
{
    Console.WriteLine($"Method2() starting, ThreadId: {Environment.CurrentManagedThreadId}...");
    Thread.Sleep(100);
    Console.WriteLine("...Method2() ending.");
}

static void Method3()
{
    Console.WriteLine($"Method3() starting, ThreadId: {Environment.CurrentManagedThreadId}...");
    Thread.Sleep(100);
    Console.WriteLine("...Method3() ending.");
}

