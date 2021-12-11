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
    /// Lógica de interacción para SalasDelAcuario.xaml
    /// </summary>
    public partial class SalasDelAcuario : Window
    {
        public SalasDelAcuario()
        {
            InitializeComponent();
        }

        private void goBack(object sender, RoutedEventArgs e)
        {
            Inicio inicio = new Inicio();
            this.Close();
            inicio.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToMamiferos(object sender, RoutedEventArgs e)
        {
            Mamiferos mamiferos = new Mamiferos();
            this.Close();
            mamiferos.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToCrustaceos(object sender, RoutedEventArgs e)
        {
            Crustaceos crustaceos = new Crustaceos();
            this.Close();
            crustaceos.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }

        private void goToTropical(object sender, RoutedEventArgs e)
        {
            Tropical tropical = new Tropical();
            this.Close();
            tropical.Show();

            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "C:/Users/javie/source/repos/Acuario/Acuario/Audios/inicio.wav";
            player.Play();
        }
    }
}
