// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("*** Use Generics to Avoid Runtime Errors ***");

ArrayList myList = new()
{
    1,
    2,
    "Invalid Element!"
};
foreach (int myInt in myList)
{
    Console.WriteLine(myInt);
}
