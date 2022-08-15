using System;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUI3AppDotNet
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow() => InitializeComponent();

        private async void Button_Click(object _, RoutedEventArgs _1)
        {
            ContentDialog contentDialog = new()
            {
                Title = "",
                Content = "Hello Reader.",
                CloseButtonText = "OK",
                XamlRoot = Content.XamlRoot,
            };
            _ = await contentDialog.ShowAsync();
        }
    }
}
