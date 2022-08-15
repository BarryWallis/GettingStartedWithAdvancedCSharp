// See https://aka.ms/new-console-template for more information

using EventsEx4;

Console.WriteLine("*** Using Event Accessors ***");

Sender _sender = new();
Receiver _receiver = new();
_sender.MyIntChanged += _receiver.GetNotificationFromSender;

_sender.MyInt = 1;
_sender.MyInt = 2;

_sender.MyIntChanged -= _receiver.GetNotificationFromSender;
_sender.MyInt = 3;