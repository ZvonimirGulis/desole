using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.Core;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Media.Playback;
using Windows.Media.Core;


namespace Desole
{

    public sealed partial class MainPage : Page
    {
        MediaPlayer player;
        public MainPage()
        {
            this.InitializeComponent();
            player = new MediaPlayer();

        }

        private void Start_Click(object sender, RoutedEventArgs e)
            {
                this.Frame.Navigate(typeof(prvi), null);
            }

            private void Story_Click(object sender, RoutedEventArgs e)
            {
                this.Frame.Navigate(typeof(prica), null);
            }

            private void Exit_Click(object sender, RoutedEventArgs e)
            {
                CoreApplication.Exit();
            }


 
        private async void MainPage1_Loaded(object sender, RoutedEventArgs e)
        {

            Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
            Windows.Storage.StorageFile file = await folder.GetFileAsync("menu_mjuza.wav");

            player.AutoPlay = true;
            player.Source = MediaSource.CreateFromStorageFile(file);

            player.Play();

            this.Frame.Navigate(typeof(MainMenu), null);
        }
    }
}
  

 
