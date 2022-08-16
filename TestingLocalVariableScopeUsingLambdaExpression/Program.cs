// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Testing Local Variable Scope with a Lambda Expression ***");

#region Using query syntax
int midPoint = 5;
List<int> intList = new(Enumerable.Range(1, 10));
IEnumerable<int> myQueryAboveMidPoint = from i in intList where i > midPoint select i;
Console.WriteLine("Numbers above mid-point (5) in intlist are: ");
foreach (int number in myQueryAboveMidPoint)
{
    Console.WriteLine(number);
}
#endregion
Console.WriteLine();

#region Using method call syntax
Console.WriteLine("Using a lambda expression, numbers above mid-point (5) in intlist are: ");
IEnumerable<int> numbersAboveMidPoint = intList.Where(x => x > midPoint);
foreach (int number in numbersAboveMidPoint)
{
    Console.WriteLine(number);
}
#endregion
