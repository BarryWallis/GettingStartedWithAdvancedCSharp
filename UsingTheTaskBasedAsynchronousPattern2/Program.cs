// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Using the Task-Based Asynchronous Pattern with a Lambda Expression (version 2) ***");

Console.WriteLine($"Main() ManagedThreadId: {Environment.CurrentManagedThreadId}");

Task<string> taskForMethod1 = Method1();

Task taskForMethod3 = taskForMethod1.ContinueWith(method3, TaskContinuationOptions.OnlyOnRanToCompletion);

Method2();

Console.WriteLine($"Task for Method1() returned: {taskForMethod1.Result}");
Task.WaitAll(taskForMethod1, taskForMethod3);

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

static void method3(Task task)
{
	Console.WriteLine($"Method3(), CurrentId: {Task.CurrentId}, ThreadId: " +
		$"{Environment.CurrentManagedThreadId} starting...");
	Thread.Sleep(20);
	Console.WriteLine($"...Method3(), CurrentId: {Task.CurrentId}, ThreadId: " +
		$"{Environment.CurrentManagedThreadId} ending.");
}
