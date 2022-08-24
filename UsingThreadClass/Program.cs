// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Asynchronous Programming Demonstration ***");

Console.WriteLine("Starting Main()...");
Thread thread = new(() =>
{
    Console.WriteLine("Method1() starting in a spearate thread...");
    Thread.Sleep(1000);
    Console.WriteLine("...Method1() ending.");
});

thread.Start();
Thread.Sleep(10);

Method2();

Console.WriteLine("... Ending Main().");

static void Method2()
{
    Console.WriteLine("Method2() starting...");
    Thread.Sleep(100);
    Console.WriteLine("...Method2() ending.");
}
