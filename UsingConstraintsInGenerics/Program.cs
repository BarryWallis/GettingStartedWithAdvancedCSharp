// See https://aka.ms/new-console-template for more information
using UsingConstraintsInGenerics;

Console.WriteLine("*** Using Constraints in Generic Programming ***");
Console.WriteLine();

IEmployee e1 = new Employee("Suresh", 1);
IEmployee e2 = new Employee("Jack", 5);
IEmployee e3 = new Employee("Jon", 7);
IEmployee e4 = new Employee("Michael", 2);
IEmployee e5 = new Employee("Amit", 3);

EmployeeStorehouse<IEmployee> storehouse = new();
storehouse.Add(e1);
storehouse.Add(e2);
storehouse.Add(e3);
storehouse.Add(e4);
storehouse.Add(e5);
storehouse.Display();