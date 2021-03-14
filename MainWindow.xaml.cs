using System.IO;
using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using static System.Net.Mime.MediaTypeNames;

namespace PaperRockScissors
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        BitmapImage paperIcon = new BitmapImage(new Uri("Images/paper.png", UriKind.RelativeOrAbsolute));
        const string pathToPaperImage = "Images/paper.png";
        public MainWindow()
        {
            InitializeComponent();
        }
        private void paperImage_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            playerMoveImage.Source = paperIcon;
        }
    }
}
