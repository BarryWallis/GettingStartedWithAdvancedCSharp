// See https://aka.ms/new-console-template for more information

using ImplementGenericInterface;

Console.WriteLine("*** Implementing Genreic Interfaces ***");

IGenericInterface<int> concreteInt = new ConcreteClass<int>();
int myInt = concreteInt.GenericMethod(5);
Console.WriteLine($"The value stored in myInt is: {myInt}");
concreteInt.NonGenericMethod();
Console.WriteLine();

IGenericInterface<string> concreteString = new ConcreteClass<string>();
string myString = concreteString.GenericMethod("Hello Reader");
Console.WriteLine($"The value stored in myString is: {myString}");
concreteString.NonGenericMethod();