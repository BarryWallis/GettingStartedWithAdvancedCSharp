// See https://aka.ms/new-console-template for more information

static int MethodOne()
{
    Console.WriteLine("A static method of Program - MethodOne() executed and threw an exception.");
    int a = 10;
    int b = 0;
    int c = a / b;
    return 1;
}

static int MethodTwo()
{
    Console.WriteLine("A static method of Program - MethodTwo() executed.");
    return 2;
}

static int MethodThree()
{
    Console.WriteLine("A static method of Program - MethodThree() executed.");
    return 3;
}

Console.WriteLine("*** A case study with a multicast delegate when we target non-void methods. ***");
Console.WriteLine();

MultiDelegate? _multiDelegate = MethodOne;
_multiDelegate += MethodTwo;
_multiDelegate += MethodThree;
int finalValue = _multiDelegate();
Console.WriteLine($"The final value is {finalValue}");

internal delegate int MultiDelegate();