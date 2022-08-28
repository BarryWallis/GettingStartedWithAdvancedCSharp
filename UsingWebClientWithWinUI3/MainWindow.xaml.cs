using System;
using System.ComponentModel;
using System.Net;
using System.Threading;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace UsingWebClientWithWinUI3
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private void StartDownloadButton_Click(object _1, RoutedEventArgs _2)
        {
#pragma warning disable SYSLIB0014 // Type or member is obsolete
            WebClient webClient = new();
#pragma warning restore SYSLIB0014 // Type or member is obsolete
            Uri sourceLocation =
                new(@"C:\Users\Barry\source\repos\GettingStartedWithAdvancedCSharp\UsingWebClient\"
                    + @"OriginalFile.txt");
            string targetLocation =
                @"C:\Users\Barry\source\repos\GettingStartedWithAdvancedCSharp\"
                + @"UsingWebClient\DownloadedFile.txt";
            webClient.DownloadFileCompleted += DownloadCompleted;
            webClient.DownloadProgressChanged += ProgressChanged;
            webClient.DownloadFileAsync(sourceLocation, targetLocation);
            Thread.Sleep(3000);
            //ContentDialog contentDialog = new()
            //{
            //    XamlRoot = Content.XamlRoot,
            //    Content = "Method1() has finished!",
            //    CloseButtonText = "Ok"
            //};
            //_ = await contentDialog.ShowAsync();
        }

        private void ProgressChanged(object _1, DownloadProgressChangedEventArgs e)
            => ProgressBar.Value = e.ProgressPercentage;

        private async void DownloadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            ContentDialog contentDialog = new()
            {
                XamlRoot = Content.XamlRoot,
                Content = "File downloaded!",
                CloseButtonText = "Ok"
            };
            _ = await contentDialog.ShowAsync();
        }

        private void ResetButton_Click(object _1, RoutedEventArgs _2) => ProgressBar.Value = 0;

        private void ExitButton_Click(object _1, RoutedEventArgs _2) => Environment.Exit(0);
    }
}
