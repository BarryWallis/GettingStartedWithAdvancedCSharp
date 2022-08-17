// See https://aka.ms/new-console-template for more information
using UsingEventsAndLambdaExpressions;

Console.WriteLine("*** Exploring Events With Lambda Expressions ***");

Sender sender = new();
EventHandler myEvent = (sender, eventArgs)
    => Console.WriteLine($"Using lambda expression, inside Main(), recieved a notification: Sender " +
    $"changed MyInt");
sender.MyIntChanged += myEvent;

sender.MyInt = 1;
sender.MyInt = 2;
Console.WriteLine();

sender.MyIntChanged -= myEvent;
sender.MyInt = 3;