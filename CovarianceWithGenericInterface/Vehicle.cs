namespace CovarianceWithGenericInterface;

internal class Vehicle
{
    public virtual void ShowMe()
        => Console.WriteLine($"Vehicle.ShowMe() hash code is: {GetHashCode()}");
}
