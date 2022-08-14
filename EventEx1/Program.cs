// See https://aka.ms/new-console-template for more information

using EventEx1;

Console.WriteLine("*** Exploring Events ***");
Sender _sender = new();
Receiver _receiver = new();
_sender.MyIntChanged += _receiver.GetNotificationFromSender!;
_sender.MyInt = 1;
_sender.MyInt = 2;

_sender.MyIntChanged -= _receiver.GetNotificationFromSender!;
_sender.MyInt = 3;

_sender.MyIntChanged += _sender.GetNotificationItself!;
_sender.MyInt = 4;