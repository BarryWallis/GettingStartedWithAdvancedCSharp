// See https://aka.ms/new-console-template for more information
internal class SharedResource
{
    public void SharedMethod()
    {
        lock (this)
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} starting....");
            Thread.Sleep(3000);
            Console.WriteLine($"{Thread.CurrentThread.Name} exiting.");
        }
    }
}