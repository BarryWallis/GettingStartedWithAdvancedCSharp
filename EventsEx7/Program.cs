// See https://aka.ms/new-console-template for more information
using EventsEx7;

Console.WriteLine("*** Exploring an Abstract Event ***");

Sender _sender = new ConcreteSender();
Receiver _receiver = new();

_sender.MyIntChanged += _receiver.GetNotificationFromSender!;
_sender.MyInt = 1;
_sender.MyInt = 2;

_sender.MyIntChanged -= _receiver.GetNotificationFromSender!;
_sender.MyInt = 3;