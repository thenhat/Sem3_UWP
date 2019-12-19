using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace I_Like_Music
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            contentFrame.Navigate(typeof(Views.Login));
        }

        private void Show_Tab(object sender, RoutedEventArgs e)
        {
            var ItemContent = (AppBarButton)sender;
            contentFrame.Navigate(typeof(Views.Login));
            if (ItemContent != null)
            {
                switch (ItemContent.Tag)
                {
                    case "Login":
                        contentFrame.Navigate(typeof(Views.Login));
                        break;

                    case "Register":
                        contentFrame.Navigate(typeof(Views.Register));
                        break;

                    case "AddSong":
                        contentFrame.Navigate(typeof(Views.AddSong));
                        break;

                    case "PlayLists":
                        contentFrame.Navigate(typeof(Views.PlayLists));
                        break;
                }
            }
        }
    }
}
