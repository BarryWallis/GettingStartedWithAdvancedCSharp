// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("*** Asynchronous Programming Demonstration Using ThreadPool ***");

Console.WriteLine("Main() starting...");

ThreadPool.QueueUserWorkItem(Method2);
ThreadPool.QueueUserWorkItem(Method3, 10);

Method1();

Console.WriteLine("...Main() ending.");

void Method1()
{
    Console.WriteLine("-Method1() starting...");
    Thread.Sleep(1000);
    Console.WriteLine("-... Method1() ending.");
}

void Method2(object? state)
{
    Console.WriteLine("--Method2() starting...");
    Thread.Sleep(100);
    Console.WriteLine("--... Method2() ending.");
}

void Method3(object? state)
{
    Console.WriteLine("---Method3() starting...");
    Debug.Assert(state is not null);
    int upperLimit = (int)state;
    for (int i = 0; i < upperLimit; i++)
    {
        Console.WriteLine($"---Method3() prints 3.0{i}");
    }
    Thread.Sleep(100);
    Console.WriteLine("---... Method3() ending.");
}
