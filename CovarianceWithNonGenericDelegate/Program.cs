internal class Program
{
    private static void Main()
    {
        Console.WriteLine("*** Testing Covariance with Delegates ***");
        VehicleDelegate vehicleDelegate1 = Vehicle.CreateVehicle;
        _ = vehicleDelegate1();

        VehicleDelegate vehicleDelegate2 = Bus.CreateBus;
        _ = vehicleDelegate2();
    }

    public class Vehicle
    {
        public static Vehicle CreateVehicle()
        {
            Vehicle vehicle = new();
            Console.WriteLine("Inside Vehicle.CreateVehicle() a vehicle is created.");
            return vehicle;
        }
    }

    public class Bus : Vehicle
    {
        public static Bus CreateBus()
        {
            Bus bus = new();
            Console.WriteLine("Inside Bus.CreateBus() a bus is created.");
            return bus;
        }
    }


    public delegate Vehicle VehicleDelegate();
}


