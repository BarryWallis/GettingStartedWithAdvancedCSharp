// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Threaded Methods With Return Types ***");

Console.WriteLine($"Inside Main(), ManagedThreadId: {Environment.CurrentManagedThreadId}");
int myInt = 0;
Thread thread1 = new(() =>
{
    Console.WriteLine($"Method1() is executing in ManagedThreadId: {Environment.CurrentManagedThreadId}");
    myInt = 5;
});

string myString = "Failure";
Thread thread2 = new(() =>
{
    Console.WriteLine($"Method2() is executing in ManagedThreadId: {Environment.CurrentManagedThreadId}");
    myString = "Success.";
});

Console.WriteLine("Starting thread1...");
thread1.Start();
Console.WriteLine("Starting thread2...");
thread2.Start();
thread1.Join();
thread2.Join();

Console.WriteLine($"Method1() returns {myInt}");
Console.WriteLine($"Method2() returns {myString}");