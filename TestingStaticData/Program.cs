// See https://aka.ms/new-console-template for more information
using TestingStaticData;

Console.WriteLine("*** Testing Static in the Conext of Generic Programming ***");

Console.WriteLine("Using intObject.");
MyGenericClass<int> intObject = new();
intObject.IncrementMe();
intObject.IncrementMe();
intObject.IncrementMe();
Console.WriteLine();

Console.WriteLine("Using stringObject.");
MyGenericClass<string> stringObject = new();
stringObject.IncrementMe();
stringObject.IncrementMe();
Console.WriteLine();

Console.WriteLine("Using doubleObject.");
MyGenericClass<double> doubleObject = new();
doubleObject.IncrementMe();
doubleObject.IncrementMe();
Console.WriteLine();

Console.WriteLine("Using intObject2.");
MyGenericClass<int> intObject2 = new();
intObject2.IncrementMe();
intObject2.IncrementMe();