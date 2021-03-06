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
using System.Media;

namespace Acuario
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

        private void goToInicio(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/boton.wav";
            player.Play();
        }

        private void exit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
