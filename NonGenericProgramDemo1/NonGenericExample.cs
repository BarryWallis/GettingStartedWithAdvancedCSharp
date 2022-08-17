namespace NonGenericProgramDemo1;

internal class NonGenericExample
{
#pragma warning disable CA1822 // Mark members as static
    public int DisplayMyInteger(int myInt) => myInt;

    public string DisplayMyString(string myString) => myString;
#pragma warning restore CA1822 // Mark members as static
}
