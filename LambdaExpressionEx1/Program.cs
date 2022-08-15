// See https://aka.ms/new-console-template for more information

Console.WriteLine("*** Exploring the Use of Lambda Expressions and Comparing It With Other Techniques ***");

int a = 21;
int b = 79;

static int Sum(int a, int b) => a + b;
Console.WriteLine("Using a normal method.");
Console.WriteLine($"Sum of {a} and {b} is: {Sum(a, b)}");
Console.WriteLine();

MyDelegate myDelegate1 = Sum;
Console.WriteLine("Using a delegate.");
Console.WriteLine($"Sum of {a} and {b} is: {myDelegate1(a, b)}");
Console.WriteLine();

MyDelegate myDelegate2 = delegate (int x, int y) { return x + y; };
Console.WriteLine("Using an anonymous method.");
Console.WriteLine($"Sum of {a} and {b} is: {myDelegate2(a, b)}");
Console.WriteLine();

MyDelegate SumOfTwoIntegers = (x, y) => x + y;
Console.WriteLine("Using a lambda expression.");
Console.WriteLine($"Sum of {a} and {b} is: {SumOfTwoIntegers(a, b)}");
Console.WriteLine();

#pragma warning disable CA1050
public delegate int MyDelegate(int x, int y);
#pragma warning restore CA1050