// See https://aka.ms/new-console-template for more information

Console.WriteLine("*** A Simple Delegate Demo ***");
Console.WriteLine();
Console.WriteLine("Calling int Sum(int, int) method without using a delegate:");
Console.WriteLine($"The Sum of 10 and 20 is: {Sum(10, 20)}");
Console.WriteLine();

DelegateWithTwoIntParametersReturningInt delegateObject = Sum;
Console.WriteLine("Calling int Sum(int, int) method using a delegate:");
Console.WriteLine($"The Sum of 10 and 20 is: {delegateObject(10, 20)}");
Console.WriteLine();

Console.WriteLine("Calling int Sum(int, int) method using invoke:");
Console.WriteLine($"The Sum of 25 and 75 is: {delegateObject.Invoke(25, 75)}");
Console.WriteLine();

static int Sum(int v1, int v2) => v1 + v2;

internal delegate int DelegateWithTwoIntParametersReturningInt(int x, int y);
