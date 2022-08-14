// See https://aka.ms/new-console-template for more information

using System.Diagnostics;

static void MethodOne() => Console.WriteLine("A static method of Program - MethodOne() executed.");

static void MethodTwo() => Console.WriteLine("A static method of Program - MethodTwo() executed.");

Console.WriteLine("*** Example of a Multicast Delegate ***");
Console.WriteLine();

MultiDelegate? _multiDelegate = MethodOne;
_multiDelegate += MethodTwo;
_multiDelegate += OutsideProgram.MethodThree;
_multiDelegate();
Console.WriteLine();

Console.WriteLine("Reducing the length of the delegate chain by removing MethodTwo().");
_multiDelegate -= MethodTwo;
Debug.Assert(_multiDelegate is not null);
_multiDelegate();

internal class OutsideProgram
{
    internal static void MethodThree()
        => Console.WriteLine("An instance method of OutsideProgram - MethodThree() executed.");
}

internal delegate void MultiDelegate();