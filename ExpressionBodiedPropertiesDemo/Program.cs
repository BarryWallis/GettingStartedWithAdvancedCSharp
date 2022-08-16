// See https://aka.ms/new-console-template for more information
using ExpressionBodiedPropertiesDemo;

Console.WriteLine("*** Experimenting with Lambda Expressions with Expression-Bodied Properties ***");

Employee _employee = new(1)
{
    Name = "Rohan Roy"
};
Console.WriteLine($"{_employee.Name} works in {_employee.Company}");
