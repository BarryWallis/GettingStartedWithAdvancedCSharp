// See https://aka.ms/new-console-template for more information
using MethodOverridingDemo;

Console.WriteLine("*** Overrding a Virtual Method ***");

BaseClass<int> intBase = new();
Console.WriteLine($"Parant class method returns {intBase.MyMethod(25)}");
Console.WriteLine();

intBase = new DerivedClass<int>();
Console.WriteLine($"Derived class method returns {intBase.MyMethod(25)}");
