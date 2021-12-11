using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Media;

namespace Acuario
{
    /// <summary>
    /// Lógica de interacción para Minijuego.xaml
    /// </summary>
    public partial class Minijuego : Window
    {
        public Minijuego()
        {
            InitializeComponent();
        }

        private void smallNemo(object sender, RoutedEventArgs e)
        {
            Slider1.Value = 80;
        }

        private void mediumNemo(object sender, RoutedEventArgs e)
        {
            Slider1.Value = 170;
        }

        private void bigNemo(object sender, RoutedEventArgs e)
        {
            Slider1.Value = 300;
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            Inicio i = new Inicio();
            this.Close();
            i.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }
    }
}
