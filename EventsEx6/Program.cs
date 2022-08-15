// See https://aka.ms/new-console-template for more information
using EventsEx6;

Console.WriteLine("*** Handling Explicit Interface Events ***");
Sender _sender = new();
ReceiverBefore _receiverBefore = new();
ReceiverAfter _receiverAfter = new();

_sender.BeforeMyIntChanged += _receiverBefore.GetNotificationFromSender!;
_sender.AfterMyIntChanged += _receiverAfter.GetNotificationFromSender!;

_sender.MyInt = 1;
Console.WriteLine();

_sender.MyInt = 2;

_sender.BeforeMyIntChanged -= _receiverBefore.GetNotificationFromSender!;
_sender.AfterMyIntChanged -= _receiverAfter.GetNotificationFromSender!;
Console.WriteLine();

_sender.MyInt = 3;