namespace GenericProgramDemo1;

internal class GenericClassDemo<T>
{
#pragma warning disable CA1822 // Mark members as static
    public T Display(T value) => value;
#pragma warning restore CA1822 // Mark members as static
}
