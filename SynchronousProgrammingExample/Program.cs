// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** A Synchronous Programming Example ***");


Method1();
Method2();

Console.WriteLine("End Main()");

void Method1()
{
    Console.WriteLine("Method1() starting...");
    Thread.Sleep(1000);
    Console.WriteLine("...Method1() ending.");
}

void Method2()
{
    Console.WriteLine("Method2() starting...");
    Thread.Sleep(100);
    Console.WriteLine("...Method2() ending.");
}
