using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App4
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private ViewModel ViewModel { get; }

        public MainPage()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel = new ViewModel();
            Loaded += MainPage_Loaded;
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            VideoRelatedTabs.SelectedItem = RelatedItem;
        }

        private object content1, content2;

        private void VideoRelatedTabs_SelectionChanged(Microsoft.UI.Xaml.Controls.NavigationView sender, Microsoft.UI.Xaml.Controls.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.SelectedItem == RelatedItem)
            {
                if (content1 == null)
                {
                    sender.Content = content1 = new Grid()
                    {
                        Background = new SolidColorBrush(Colors.Aqua)
                    };
                }
                sender.Content = content1;
            }
            else if (args.SelectedItem == CommentItem)
            {
                if (content2 == null)
                {
                    content2 = new Grid()
                    {
                        Background = new SolidColorBrush(Colors.Green)
                    };
                }

                sender.Content = content2;
            }
        }
    }

    class ViewModel
    {
        public string Title { get; set; } = "Header";
    }
}
