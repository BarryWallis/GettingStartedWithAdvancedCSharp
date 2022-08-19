namespace CovarianceWithGenericInterface;

internal class Bus : Vehicle
{
    public override void ShowMe()
        => Console.WriteLine($"Bus.ShowMe() hash code is: {GetHashCode()}");
}
