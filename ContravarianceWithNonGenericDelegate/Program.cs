// See https://aka.ms/new-console-template for more information

Console.WriteLine("*** Exploring Contravariance with Non-Generic Delegates ***");
Vehicle vehicle = new();
Bus bus = new();

BusDelegate busDelegate = bus.ShowBus;
busDelegate(bus);
Console.WriteLine();

BusDelegate contravariantBusDelegate = vehicle.ShowVehicle;
contravariantBusDelegate(bus);

internal class Vehicle
{
#pragma warning disable CA1822 // Mark members as static
    public void ShowVehicle(Vehicle vehicle)
#pragma warning restore CA1822 // Mark members as static
    {
        Console.WriteLine("Vehicle.ShowVehicle(Vehicle) is called.");
        Console.WriteLine($"vehicle.GetHashCode() is: {vehicle.GetHashCode()}");
    }
}

internal class Bus : Vehicle
{
#pragma warning disable CA1822 // Mark members as static
    public void ShowBus(Bus bus)
#pragma warning restore CA1822 // Mark members as static
    {
        Console.WriteLine("Bus.ShowBus(Bus) is called.");
        Console.WriteLine($"bus.GetHashCode() is: {bus.GetHashCode()}");
    }
}

internal delegate void BusDelegate(Bus bus);