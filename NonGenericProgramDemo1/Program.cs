// See https://aka.ms/new-console-template for more information
using NonGenericProgramDemo1;

Console.WriteLine("*** A Non-Generic Program Demonstration ***");

NonGenericExample nonGenericExample = new();
Console.WriteLine($"DisplayMyInteger(int): {nonGenericExample.DisplayMyInteger(123)}");
Console.WriteLine($"DisplayMyString(string): " +
    $"{nonGenericExample.DisplayMyString("DisplayMyString(string) inside NonGenericProgramDemo1 was called")}");