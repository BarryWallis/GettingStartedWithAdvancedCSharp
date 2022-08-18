// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Using Generic Delegates ***");

Console.WriteLine("Using Func<> delegate.");
Func<string, int, double, string> employeeObject = DisplayEmployeeDetails;
Console.WriteLine(employeeObject("Amit", 1, 1025.75));
Console.WriteLine(employeeObject("Sumit", 2, 3024.55));
Console.WriteLine();

Console.WriteLine("Using action delegate.");
Action<int, int, int> sum = CalculateSumOfThreeInts;
sum(10, 3, 7);
sum(5, 10, 15);
Console.WriteLine();

Console.WriteLine("Using Predicate delegate.");
Func<int, bool> isGreater = IsGreaterThan100;
Console.WriteLine($"101 is greater than 100? {isGreater(101)}");
Console.WriteLine($"99 is greater than 99? {isGreater(99)}");
Console.WriteLine();

bool IsGreaterThan100(int input) => input > 100;

void CalculateSumOfThreeInts(int i1, int i2, int i3)
    => Console.WriteLine($"Sum of {i1}, {i2}, {i3} is: {i1 + i2 + i3}");

string DisplayEmployeeDetails(string name, int employeeId, double salary)
    => $"Employee Name: {name}, " + $"id: {employeeId}, salary: {salary}";
