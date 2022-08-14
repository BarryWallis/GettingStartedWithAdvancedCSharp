namespace CaseStudyWithOverloadedMethods;

internal class Program
{
    private static int Sum(int a, int b) => a + b;

#pragma warning disable IDE0051 // Remove unused private members
    private static int Sum(int a, int b, int c) => a + b + c;
#pragma warning restore IDE0051 // Remove unused private members

    private static void Main()
    {

        Console.WriteLine("*** A case study with overloaded methods ***");

        DelegateWithTwoIntParamtersReturnsInt delegateObject = Sum;
        Console.WriteLine($"Calling int Sum(int, int) method using delegate.");
        Console.WriteLine($"Sum of 10 and 20 is: {delegateObject(10, 20)}");
    }
}

internal delegate int DelegateWithTwoIntParamtersReturnsInt(int x, int y);