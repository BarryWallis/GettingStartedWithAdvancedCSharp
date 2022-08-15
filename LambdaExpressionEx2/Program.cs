internal class Program
{
    public delegate void DelegateWithNoParameters();
    public delegate int DelegateWithOneIntParameter(int x);
    public delegate void DelegateWithTwoIntParameters(int x, int y);

    private static void Main()
    {
        Console.WriteLine("*** Experimenting with Lambda Expressions with Different Prameters ***");
        Console.WriteLine();

        Method1(5, 10);


        Console.WriteLine();

#pragma warning disable IDE0039 // Use local function
        DelegateWithNoParameters delegateWithNoParameters
            = () => Console.WriteLine("Using lambda expression with no parameters, printing Hello");
        delegateWithNoParameters();
        Console.WriteLine();

        DelegateWithOneIntParameter delegateWithOneIntParameter = (x) => x * x;
        Console.WriteLine($"Using a lambda expression with one parameter, square of 5 is " +
            $"{delegateWithOneIntParameter(5)}");
        Console.WriteLine();

        DelegateWithTwoIntParameters delegateWithTwoIntParameters = (x, y) =>
        {
            Console.WriteLine("Using a lambda expression with two parameters.");
            Console.WriteLine($"Sum of {x} and {y} is {x + y}");
        };
#pragma warning restore IDE0039 // Use local function
        delegateWithTwoIntParameters(10, 20);
        Console.WriteLine();

        static void Method1(int a, int b)
        {
            Console.WriteLine("This is Method1(int, int) without lambda expression.");
            Console.WriteLine($"Sum of {a} and {b} is {a + b}");
        }
    }
}
