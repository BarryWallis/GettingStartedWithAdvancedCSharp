// See https://aka.ms/new-console-template for more information

static int Sum(int x, int y) => x + y;

Console.WriteLine("*** Comparing the behavior of a static method and an instance method when assigning them to " +
    "a delegate instance. ***");
Console.WriteLine("");

Console.WriteLine("Assigning a static method to a delegate object.");
DelegateWithTwoIntParametersReturnsInt delegateObject = Sum;
Console.WriteLine("Calling int Sum(int, int) method of Program class using a delegate.");
Console.WriteLine($"Sum of 10 and 20 is: {delegateObject(10, 20)}");
Console.WriteLine($"delegateObject.Target = {delegateObject.Target}");
Console.WriteLine($"delegateObject.Target is null? {delegateObject.Target is null}");
Console.WriteLine($"delegateObject.Method = {delegateObject.Method}");
Console.WriteLine();

OutsideProgram outsideObject = new();
Console.WriteLine("Assigning an instance method to a delegate object.");
delegateObject = outsideObject.CalculateSum;
Console.WriteLine("Calling int CalculateSum(int, int) method of OutsidePogram class using a delegate");
Console.WriteLine($"Sum of 50 and 79 is: {delegateObject(50, 70)}");
Console.WriteLine($"delegateObject.Target = {delegateObject.Target}");
Console.WriteLine($"delegateObject.Target is null? {delegateObject.Target is null}");
Console.WriteLine($"delegateObject.Method = {delegateObject.Method}");

internal class OutsideProgram
{
#pragma warning disable CA1822 // Mark members as static
    public int CalculateSum(int x, int y) => x + y;
#pragma warning restore CA1822 // Mark members as static
}

internal delegate int DelegateWithTwoIntParametersReturnsInt(int x, int y);
