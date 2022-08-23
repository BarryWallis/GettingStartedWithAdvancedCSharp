// See https://aka.ms/new-console-template for more information

Console.WriteLine("*** Comparing Foreground and Background Threads ***");

Thread.CurrentThread.Name = "Main Thread";
Console.WriteLine($"{Thread.CurrentThread.Name} has started.");

Thread childThread = new(MyMethod)
{
	Name = "Child Thread-1"
};
Console.WriteLine("Starting Child Thread-1...");
childThread.Start();
childThread.IsBackground = true;

Console.WriteLine("Control comes at end of Main().");

static void MyMethod()
{
	Console.WriteLine($"{Thread.CurrentThread.Name} entering MyMethod()...");
	for (int i = 0; i < 10; i++)
	{
		Console.WriteLine($"{Thread.CurrentThread.Name} from MyMethod() prints {i}");
		Thread.Sleep(100);
	}
}