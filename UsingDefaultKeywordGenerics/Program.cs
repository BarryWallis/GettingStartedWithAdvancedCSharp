// See https://aka.ms/new-console-template for more information
using System.Numerics;

using UsingDefaultKeywordInGenerics;

Console.WriteLine("*** Using Default Keyword in Generic Programming ***");
PrintDefault<int>();
PrintDefault<double>();
PrintDefault<bool>();
PrintDefault<string>();
PrintDefault<int?>();
PrintDefault<Complex>();
PrintDefault<List<int>>();
PrintDefault<List<string>>();
PrintDefault<MyClass>();
PrintDefault<MyStruct>();

static void PrintDefault<T>()
{
    T? defaultValue = default;
    string? printMe;
    printMe = (defaultValue is null) ? "null" : defaultValue.ToString();
    Console.WriteLine($"Default value of {typeof(T)} is {printMe}");
}
