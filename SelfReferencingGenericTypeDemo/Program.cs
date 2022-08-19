// See https://aka.ms/new-console-template for more information
using SelfReferencingGenericTypeDemo;

Console.WriteLine("*** Self-Referencing Generic Type Demo ***");

Console.WriteLine("Check whether two employees are the same.");
Console.WriteLine();

Employee employee1 = new("Chemisty", 1);
Employee employee2 = new("Math", 2);
Employee employee3 = new("Computer Science", 1);
Employee employee4 = new("Math", 2);
Employee? employee5 = null;
Console.WriteLine($"Comparing employee1 and employee3: {employee1.CheckEqualityWith(employee3)}");
Console.WriteLine($"Comparing employee2 and employee4: {employee2.CheckEqualityWith(employee4)}");
Console.WriteLine($"Comparing employee2 and employee5: {employee2.CheckEqualityWith(employee5)}");
