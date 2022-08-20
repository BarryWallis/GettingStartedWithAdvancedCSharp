// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

Console.WriteLine("*** Parameterized Thread Start Delegate Demonstration ***");

Console.WriteLine("Main thread has started.");

Thread thread1 = new(Method1);
Thread thread2 = new(Method2);
Thread thread3 = new(Method3);

Console.WriteLine("Starting thread1.");
thread1.Start();

Console.WriteLine("Starting thread2.");
thread2.Start();

Console.WriteLine("Starting thread3 with a ParameterizedThreadStart delegate.");
thread3.Start(15);

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
		Console.WriteLine($"--thread2 from Method2() prints {i}");
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