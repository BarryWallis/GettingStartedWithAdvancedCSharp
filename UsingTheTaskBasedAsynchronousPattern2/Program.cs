// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Using the Task-Based Asynchronous Pattern with a Lambda Expression ***");

Console.WriteLine($"Main() ManagedThreadId: {Environment.CurrentManagedThreadId}");

Task<string> taskForMethod1 = Method1();

Method2();

Console.WriteLine($"Task for Method1() returned: {taskForMethod1.Result}");

static Task<string> Method1()
{
	return Task.Run(() =>
	{
		string result = "Failure";
		try
		{
			Console.WriteLine($"Method1(), Task.CurrentId: {Task.CurrentId}, ThreadId: " +
				$"{Environment.CurrentManagedThreadId} starting...");
			Thread.Sleep(3000);
			Console.WriteLine("...Method1() ending.");
			result = "Success";
		}
		catch (Exception exception)
		{
			Console.WriteLine($"Exception caught {exception.Message}");
		}

		return result;
	});
}

static void Method2()
{
	Console.WriteLine($"Method2(), ThreadId: {Environment.CurrentManagedThreadId} starting...");
	Thread.Sleep(100);
	Console.WriteLine("...Method2() ending.");
}
