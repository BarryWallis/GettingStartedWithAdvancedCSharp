// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("*** Asynchronous Programming Demonstraation Using ThreadPool with Lambda Expression ***");

Console.WriteLine("Main() starting...");
ThreadPool.QueueUserWorkItem(Method2);

ThreadPool.QueueUserWorkItem(number =>
{
    Console.WriteLine("--Method3() starting...");
    Debug.Assert(number is not null);
    int upperLimit = (int)number;
    for (int i = 0; i < upperLimit; i++)
    {
        Console.WriteLine($"---Method3() prints 3.0{i}");
    }
    Thread.Sleep(100);
    Console.WriteLine("---...Method3() ending");
}, 10);

Method1();

Console.WriteLine("...Main() ending.");

void Method1()
{
    Console.WriteLine("-Method1() starting...");
    Thread.Sleep(500);
    Console.WriteLine("-...Method1() ending.");
}

void Method2(object? state)
{
    Console.WriteLine("--Method2() starting...");
    Thread.Sleep(500);
    Console.WriteLine("--...Method2() ending.");
}
