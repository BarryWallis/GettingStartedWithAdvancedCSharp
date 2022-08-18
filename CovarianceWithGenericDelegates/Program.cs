// See https://aka.ms/new-console-template for more information
using CovarianceWithGenericDelegates;

Console.WriteLine("*** Testing Ccovariance With a Generic Delegte ***");

Console.WriteLine("Normal ussge:");
CovariantDelegate<Vehicle> vehicle = GetOneVehicle;
vehicle();
CovariantDelegate<Bus> bus = GetOneBus;
bus();
Console.WriteLine();

Console.WriteLine("Using covariance:");
vehicle = bus;
vehicle();
Console.WriteLine();

Console.WriteLine("End of covariance testing.");

Bus GetOneBus()
{
    Console.WriteLine("Creating one bus and returning it.");
    return new Bus();
}

Vehicle GetOneVehicle()
{
    Console.WriteLine("Creating one vehicle and returning it.");
    return new Bus();
}

internal delegate TResult CovariantDelegate<out TResult>();
