// See https://aka.ms/new-console-template for more information
using EventsEx5;

Console.WriteLine("*** Exploring an Event with an Interface ***");

Sender _sender = new();
Receiver _receiver = new();

_sender.MyIntChanged += _receiver.GetNotificationFromSender!;
_sender.MyInt = 1;
_sender.MyInt = 2;

_sender.MyIntChanged -= _receiver.GetNotificationFromSender!;
_sender.MyInt = 3;