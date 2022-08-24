// See https://aka.ms/new-console-template for more information
internal class SharedResource
{
#pragma warning disable CA1822 // Mark members as static
    public void SharedMethod()
#pragma warning restore CA1822 // Mark members as static
    {
        Console.WriteLine($"{Thread.CurrentThread.Name} starting....");
        Thread.Sleep(3000);
        Console.WriteLine($"{Thread.CurrentThread.Name} exiting.");
    }
}