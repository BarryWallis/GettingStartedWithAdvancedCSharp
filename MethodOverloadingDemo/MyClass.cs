namespace MethodOverloadingDemo;

internal class MyClass<T, U>
{
#pragma warning disable IDE0060 // Remove unused parameter
#pragma warning disable CA1822 // Mark members as static
    public void MyMethod(T parameter1, U parameter2)
        => Console.WriteLine("Inside MyMethod(T parameter1, U parameter2)");

    public void MyMethod(U parameter1, T parameter2)
        => Console.WriteLine("Inside MyMethod(U parameter1, T parameter2)");

    public void MyMethod2(int a, double b)
        => Console.WriteLine("Inside MyMethod2(int a, double b)");

    public void MyMethod2(double b, int a)
        => Console.WriteLine("Inside MyMethod2(double b, int a)");
#pragma warning restore CA1822 // Mark members as static
#pragma warning restore IDE0060 // Remove unused parameter
}
