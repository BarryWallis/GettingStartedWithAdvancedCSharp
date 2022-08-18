// See https://aka.ms/new-console-template for more information
Console.WriteLine("*** Using Generics to Avoid Run-TIme Errors ***");

List<int> myList = new()
{
    10,
    20
};
foreach (int myInt in myList)
{
    Console.WriteLine(myInt);
}