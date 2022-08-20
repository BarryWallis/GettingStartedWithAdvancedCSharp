namespace TestingStaticData;

internal class MyGenericClass<T>
{
    public static int Count { get; private set; } = 0;

#pragma warning disable CA1822 // Mark members as static
    public void IncrementMe() => Console.WriteLine($"Incremented value is {++Count}");
#pragma warning restore CA1822 // Mark members as static
}
