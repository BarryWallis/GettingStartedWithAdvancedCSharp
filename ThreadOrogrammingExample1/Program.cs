// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Thread Demonstration 1***");

Console.WriteLine("Main thread has started.");
Thread thread1 = new(Method1);
Thread thread2 = new(Method2);

Console.WriteLine("Starting thread1.");
thread1.Start();

Console.WriteLine("Starting thread2.");
thread2.Start();

Console.WriteLine("Control comes at the end of Main().");

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
        Console.WriteLine($"-thread2 from Method2() prints 2.0{i}");
    }
}
