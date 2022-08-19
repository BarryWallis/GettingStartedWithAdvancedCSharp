// See https://aka.ms/new-console-template for more information
using MethodOverloadingDemo;

Console.WriteLine("*** Method Overloading Demo ***");

MyClass<int, double> object1 = new();
object1.MyMethod(1, 2.3);
object1.MyMethod2(1, 2.3);
object1.MyMethod2(2.3, 1);
