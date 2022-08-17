// See https://aka.ms/new-console-template for more information
using GenericProgramDemo1;

Console.WriteLine("*** Introduction to Generic Programming ***");

GenericClassDemo<int> myGenericClassInt = new();
Console.WriteLine($"Display(T) returns: {myGenericClassInt.Display(1)}");

GenericClassDemo<string> myGenericClassString = new();
Console.WriteLine($"Display(T) returns: {myGenericClassString.Display("A generic method was called.")}");

GenericClassDemo<double> myGenericClassDouble = new();
Console.WriteLine($"Display(T) returns: {myGenericClassDouble.Display(123.45)}");