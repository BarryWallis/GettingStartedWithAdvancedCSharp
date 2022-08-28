// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Different Methods for Creating Tasks ***");

Console.WriteLine($"Main().ThreadId: {Thread.CurrentThread.ManagedThreadId} starting...");

Task task1 = new(MyMethod);
task1.Start();

TaskFactory taskFactory = new();
Task task2 = taskFactory.StartNew(MyMethod);
Task task3 = taskFactory.StartNew(MyMethod);

Task.WaitAll(task1, task2, task3);

Console.WriteLine($"...Main().ThreadId: {Thread.CurrentThread.ManagedThreadId} ending.");

void MyMethod()
{
    Console.WriteLine($"Task.CurrentId: {Task.CurrentId}, Thread.CurrentThread.ManagedThreadId: " +
        $"{Thread.CurrentThread.ManagedThreadId} starting...");
    Thread.Sleep(100);
    Console.WriteLine($"...Task.CurrentId: {Task.CurrentId}, Thread.CurrentThread.ManagedThreadId: " +
        $"{Thread.CurrentThread.ManagedThreadId} ending.");
}

