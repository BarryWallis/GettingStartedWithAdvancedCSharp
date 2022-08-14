// See https://aka.ms/new-console-template for more information

using EventsEx2;

Console.WriteLine("*** Exploring a Custom Event ***");

Sender sender = new();
Receiver receiver = new();
sender.MyIntChanged += receiver.GetNotificationFromSender;

sender.MyInt = 1;
sender.MyInt = 2;
sender.MyIntChanged -= receiver.GetNotificationFromSender;

sender.MyInt = 3;