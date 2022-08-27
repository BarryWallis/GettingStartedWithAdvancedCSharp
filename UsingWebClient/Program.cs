// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Net;

Console.WriteLine("*** Event Based Asynchronous Program Demostration ***");

bool isDownloadComplete = false;
Console.WriteLine("Main() startng...");

Console.WriteLine("Starting download...");
#pragma warning disable SYSLIB0014 // Type or member is obsolete
WebClient webClient = new();
#pragma warning restore SYSLIB0014 // Type or member is obsolete
Uri uri =
    new(@"C:\Users\Barry\source\repos\GettingStartedWithAdvancedCSharp\UsingWebClient\"
        + @"OriginalFile.txt");
string targetLocation =
    @"C:\Users\Barry\source\repos\GettingStartedWithAdvancedCSharp\"
    + @"UsingWebClient\DownloadedFile.txt";
webClient.DownloadFileCompleted += Completed;
webClient.DownloadFileAsync(uri, targetLocation);
Method2();

Console.WriteLine("...Main() ending.");
while (!isDownloadComplete)
{
    //
}

void Method2()
{
    Console.WriteLine("Method2() starting...");
    Console.WriteLine("...Method2() ending.");
}

void Completed(object? sender, AsyncCompletedEventArgs e)
{
    if (e.Error is null)
    {
        Console.WriteLine("Download completed!");
    }
    else
    {
        Console.WriteLine(e.Error.Message);
    }

    isDownloadComplete = true;
}