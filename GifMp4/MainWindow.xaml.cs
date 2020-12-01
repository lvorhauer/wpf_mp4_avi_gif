using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfAnimatedGif;

namespace GifMp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private string BaseDirectory { 
            get 
            {
                return new DirectoryInfo(System.AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.FullName;
            } 
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var uri = new Uri(@$"{BaseDirectory}\gif2.gif");
            var image = new BitmapImage(uri);

            ImageBehavior.SetAnimatedSource(Img01, null);
            Img01.Source = image;
        }
        private void Button_Click2(object sender, RoutedEventArgs e)
        {

            var uri = new Uri(@$"{BaseDirectory}\gif.gif");
            var image = new BitmapImage(uri);
            ImageBehavior.SetAnimatedSource(Img01, image);

        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            Media01.Source = null;
            Media01.Source = new Uri(@$"{BaseDirectory}\mp4.mp4");
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {

            Media01.Source = null;
            Media01.Source = new Uri(@$"{BaseDirectory}\small.avi");
        }

        private void Media01_MediaEnded(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("ende");
        }
    }
}
