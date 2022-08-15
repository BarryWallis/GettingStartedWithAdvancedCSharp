// See https://aka.ms/new-console-template for more informat
using ExpressionBodiedMethodDemo;

Console.WriteLine("*** Experimenting with a Lambda Expression with an Expression-Bodied Method ***");
Console.WriteLine();

int result1 = Test.CalculateSum1(5, 7);
Console.WriteLine($"Using a normal method, CalaculateSum1(5, 7) results: {result1}");
Console.WriteLine();

int result2 = Test.CalculateSum2(5, 7);
Console.WriteLine($"Using expression syntax for CalaculateSum1(5, 7) results: {result2}");
Console.WriteLine();
