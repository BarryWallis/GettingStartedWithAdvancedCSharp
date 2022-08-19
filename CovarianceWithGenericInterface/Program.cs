// See https://aka.ms/new-console-template for more information
using CovarianceWithGenericInterface;

Console.WriteLine("*** Using Covariance With a Generic Interface ***");

Console.WriteLine("==> Remember that T in IEnumerable<T> is covariant");
Bus bus1 = new();
Bus bus2 = new();
List<Bus> busList = new();
busList.Add(bus1);
busList.Add(bus2);
IEnumerable<Bus> buses = busList;
IEnumerable<Vehicle> vehicles = buses;
foreach (Vehicle vehicle in vehicles)
{
    vehicle.ShowMe();
}