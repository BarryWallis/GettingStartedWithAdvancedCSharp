// See https://aka.ms/new-console-template for more information
using ContravarianceWithGenericDelegates;

Console.WriteLine("*** Testing Conravariance With Generic Delegates ***");

Vehicle vehicle = new();
Bus bus = new();

Console.WriteLine("Normal usage:");

ContravariantDelegate<Vehicle> contravariantVehicle = ShowVehicleType;
contravariantVehicle(vehicle);
ContravariantDelegate<Bus> contravariantBus = ShowBusType;
contravariantBus(bus);
Console.WriteLine();

Console.WriteLine("Using contravariance:");
contravariantBus = contravariantVehicle;
contravariantBus(bus);

void ShowBusType(Bus bus) => bus.ShowMe();

void ShowVehicleType(Vehicle vehicle) => vehicle.ShowMe();

internal delegate void ContravariantDelegate<in T>(T t);