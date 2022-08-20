// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

using ThreadProgrammingExample4;

Console.WriteLine("*** Thread Demonstration 4 ***");

Console.WriteLine("Main thread has started.");

Thread thread1 = new(Method1);
Thread thread2 = new(Method2);
Thread thread3 = new(Method3);
Thread thread4 = new(Method4);

Console.WriteLine("Starting thread1");
thread1.Start();

Console.WriteLine("Starting thread2.");
thread2.Start();

Console.WriteLine("Starting thread3. A parameterized delegate.");
thread3.Start(15);

Console.WriteLine("Starting thread4. A parameterized delegate.");
thread4.Start(new Boundaries(0, 10));

thread1.Join();
thread2.Join();
thread3.Join();

Console.WriteLine("Main() ends now.");

static void Method1()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"-thread1 from Method1() prints {i}");
    }
}
static void Method2()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"--thread2 from Method2() prints 2.0{i}");
    }
}

static void Method3(object? number)
{
    Debug.Assert(number is not null);
    int upperLimit = (int)number;
    for (int i = 0; i < upperLimit; i++)
    {
        Console.WriteLine($"---thread3 from Method3() prints 3.0{i}");
    }
}

static void Method4(object? limits)
{
    Debug.Assert(limits is not null);
    Debug.Assert(limits is Boundaries);
    Boundaries boundaries = (limits as Boundaries)!;
    for (int i = boundaries.LowerLimit; i < boundaries.UpperLimit; i++)
    {
        Console.WriteLine($"----thread4 from Method4() prints 4.0{i}");
    }
}