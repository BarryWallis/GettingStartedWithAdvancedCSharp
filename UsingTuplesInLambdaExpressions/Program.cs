// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Using Tuples in Lambda Expressions ***");

Tuple<int, double> inputTuple = Tuple.Create(1, 2.3);

Console.WriteLine("Content of input tuple:");
Console.WriteLine($"Item1: {inputTuple.Item1}");
Console.WriteLine($"Item1: {inputTuple.Item2}");
Console.WriteLine();

Tuple<int, double> resultantTuple = MakeDoubleMethod(inputTuple);
Console.WriteLine("Passing tuple as an input argument in a normal method which returns a tuple.");
Console.WriteLine("Content of resultant tuple:");
Console.WriteLine($"Item1: {resultantTuple.Item1}");
Console.WriteLine($"Item2: {resultantTuple.Item2}");
Console.WriteLine();

MakeDoubleDelegate delegateObject
    = (input) => Tuple.Create(inputTuple.Item1 * 2, inputTuple.Item2 * 2);
Tuple<int, double> resultantTupleUsingLambda = delegateObject(inputTuple);
Console.WriteLine("Using delegate and lambda exprssion with tuple.");
Console.WriteLine("Using lmabda expression, resultant tuple:");
Console.WriteLine($"Item1: {resultantTupleUsingLambda.Item1}");
Console.WriteLine($"Item2: {resultantTupleUsingLambda.Item2}");
Console.WriteLine();

static Tuple<int, double> MakeDoubleMethod(Tuple<int, double> input)
    => Tuple.Create(input.Item1 * 2, input.Item2 * 2);

internal delegate Tuple<int, double> MakeDoubleDelegate(Tuple<int, double> input);