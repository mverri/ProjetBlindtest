using System;
using System.Collections.Generic;
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

namespace WpfApplication1
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       
        MusicPlayer player = new MusicPlayer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void open_Click(object sender, EventArgs e)
        {
           // openFileDialog1.ShowDialog();
        }      
      
       

        private void play_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "C:\\Users\\Chantal\\Desktop\\Michael Jackson\\01 Bad.mp3";
            player.open("C:\\Users\\Chantal\\Desktop\\Michael Jackson");
            player.play();
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            player.stop();
        }
    }
    
}
